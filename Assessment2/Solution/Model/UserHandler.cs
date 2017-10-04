using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Assessment2.Solution.Model.Users.Abs;
using Assessment2.Solution.Model.Users.Impl;

namespace Assessment2.Solution.Model {

    public class UserHandler {

        private readonly List<User> _users = new List<User>();
        
        public User LoggedInUser { get; set; }

        public bool LoadAllUsers() {
            try {

                var users = new List<User>();

                users.AddRange(PopulateList("../../Data/Guest.txt", LoadGuest));
                users.AddRange(PopulateList("../../Data/Admin.txt", LoadAdmin));

                _users.Clear();
                _users.AddRange(users);

                //only mutate the collection if loaded successfully
                
                return true;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return false;
        }

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

        private List<T> PopulateList<T>(string fileLocation, DataLoader<T> loader) where T : User {
            var output = new List<T>();
            using (var reader = new StreamReader(fileLocation)) {
                while (!reader.EndOfStream) {
                    
                    var user = loader(reader.ReadLine().Split(','));
                    
                    output.Add(user);
                }
            }
            return output;
        }
        
        private Guest LoadGuest(string[] input) {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (input.Length != 7) throw new ArgumentException($"Input array must be of length 7. '{string.Join(",", input)}'", nameof(input));
            return new Guest(input[0], input[1], input[2], input[3], DateTime.Parse(input[4]));
        }

        private Admin LoadAdmin(string[] input) {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (input.Length != 7) throw new ArgumentException($"Input array must be of length 7. '{string.Join(",", input)}'", nameof(input));
            if (!Enum.TryParse<Admin.AdminType>(input[4], out var type)) throw new InvalidEnumArgumentException("Unable to parse admin type.");
            return new Admin(input[0], input[1], input[2], input[3], type);
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