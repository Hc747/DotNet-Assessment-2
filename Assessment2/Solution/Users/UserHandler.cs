using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using Assessment2.Solution.MVCO.Observer;
using Assessment2.Solution.Users.Abs;
using Assessment2.Solution.Users.Impl;

namespace Assessment2.Solution.Users {

    public class UserHandler : Observable {

        //private readonly List<User> _users = new List<User>();
        //TODO: enquire as to whether or not this is allowed.
        private readonly HashSet<User> _users = new HashSet<User>();
        
        public User LoggedInUser { get; private set; } //TODO: update

        public List<User> Users {
            get {
                if (LoggedInUser is Admin)
                    return _users.ToList();
                return _users.Where(user => user is Guest).ToList();
            }
        }

        public bool Login(string username, string password) {
            LoggedInUser = _users.FirstOrDefault(u => u.CheckUsernameAndPassword(username, password));
            return LoggedInUser != null;
        }

        public bool Logout() {
            var success = LoggedInUser != null;
            LoggedInUser = null;
            return success;
        }

        public bool AddUser(User user, out string error) {
            var success = !_users.Contains(user);

            if (!success) {
                error = $"Sorry, the username '{user.Username}' is already taken.";
                return false;
            }

            _users.Add(user);
            
            Update();

            error = (success = SaveAllUsers()) ? null : "An error occured while attempting to save all users.";
            
            return success;
        }

        public bool LoadAllUsers() {
            try {

                var users = new List<User>();

                users.AddRange(Load("Assessment2.Data.Guest.txt", LoadGuest));
                users.AddRange(Load("Assessment2.Data.Admin.txt", LoadAdmin));

                _users.Clear();

                foreach (var user in users)
                    _users.Add(user);
                
                //only mutate the collection if loaded successfully

                Update();
                
                return true;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        //TODO: Implement proper saving
        public bool SaveAllUsers() {
            
            var writers = new Dictionary<string, StreamWriter>();
            var success = true;

            foreach (var user in _users) {

                var location = user.GetFileLocation();

                var writer = writers.LazyGet(location, new Lazy<StreamWriter>(() => new StreamWriter(location, false)));

                if (!user.WriteToFile(writer))
                    success = false;

            }

            foreach (var writer in writers.Values) using (writer) {}
            //TODO: make this code more obvious

            return success;
        }
        
        private delegate T DataLoader<out T>(string[] input) where T : User;

        private List<T> Load<T>(string fileLocation, DataLoader<T> loader) where T : User {
            var output = new List<T>();
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(fileLocation)) {
                using (var reader = new StreamReader(stream)) {
                    while (!reader.EndOfStream) {
                    
                        var user = loader(reader.ReadLine()?.Split(','));
                    
                        output.Add(user);
                    }
                }
            }
            return output;
        }
        
        private Guest LoadGuest(string[] input) {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (input.Length != 7) throw new ArgumentException($"Input array must be of length 7. '{string.Join(",", input)}'", nameof(input));
            return new Guest(input[0], input[1], input[2], input[3], DateTime.Parse(input[4]), int.Parse(input[5]), double.Parse(input[6]));
        }

        private Admin LoadAdmin(string[] input) {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (input.Length != 7) throw new ArgumentException($"Input array must be of length 7. '{string.Join(",", input)}'", nameof(input));
            if (!Enum.TryParse<Admin.AdminType>(input[4], out var type)) throw new InvalidEnumArgumentException("Unable to parse admin type.");
            return new Admin(input[0], input[1], input[2], input[3], type, int.Parse(input[5]), double.Parse(input[6]));
        }

    }

    internal static class DictionaryExtension {

        public static V LazyGet<K, V>(this IDictionary<K, V> dictionary, K key, Lazy<V> lazy) {
            V value;
            if (!dictionary.ContainsKey(key))
                dictionary[key] = value = lazy.Value;
            else
                value = dictionary[key];
            return value;
        }

    }

}