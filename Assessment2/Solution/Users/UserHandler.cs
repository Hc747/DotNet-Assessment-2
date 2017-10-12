using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Assessment2.Solution.Users.Abs;
using Assessment2.Solution.Users.Impl;

namespace Assessment2.Solution.Users {

    public class UserHandler {

        public User LoggedInUser { get; private set; } //TODO: update

        public BindingList<User> Users { get; } = new BindingList<User>();

        public bool Login(string username, string password) {
            LoggedInUser = Users.FirstOrDefault(u => u.CheckUsernameAndPassword(username, password));
            return LoggedInUser != null;
        }

        public bool Logout() {
            var success = LoggedInUser != null;
            LoggedInUser = null;
            return success;
        }

        public bool AddUser(User user, out string error) {
            var success = !Users.Any(u => Equals(u, user));

            if (!success) {
                error = $"Sorry, the username '{user.Username}' is already taken.";
                return false;
            }

            Users.Add(user);

            error = (success = SaveAllUsers()) ? null : "An error occured while attempting to save all users.";
            
            return success;
        }

        public bool Replace(User current, User replacement, out string error) {
            var index = Users.IndexOf(current);

            var success = index > -1;

            if (!success) {
                error = $"Unable to replace {current.GetShortUserString() ?? "null"} with {replacement.GetShortUserString() ?? "null"}";
                return false;
            }

            replacement.PropertyChanged += (sender, args) => SaveAllUsers();//TODO document: TODO MAKE SURE ONLY DONE ONCE

            Users[index] = replacement;

            error = (success = SaveAllUsers()) ? null : "An error occured while attempting to save all users.";

            return success;
        }

        public bool LoadAllUsers() {
            try {

                var users = new List<User>();

                users.AddRange(Load(Path.Combine("Data", "Guest.txt"), LoadGuest));
                users.AddRange(Load(Path.Combine("Data", "Admin.txt"), LoadAdmin));

                Users.Clear();

                foreach (var user in users) {
                    user.PropertyChanged += (sender, args) => SaveAllUsers();//TODO document
                    Users.Add(user);
                }

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

            foreach (var user in Users) {

                var location = Path.Combine("..", "..", user.GetFileLocation());

                var writer = writers.LazyGet(location, new Lazy<StreamWriter>(() => new StreamWriter(location, false)));

                if (!user.WriteToFile(writer))
                    success = false;

            }

            foreach (var writer in writers.Values) using (writer) {}
            //TODO: make this code more obvious

            return success;
        }
        
        private delegate T DataLoader<out T>(string[] input) where T : User;

        private List<T> Load<T>(string fileLocation, DataLoader<T> load) where T : User {
            var output = new List<T>();

            using (var reader = new StreamReader(Path.Combine("..", "..", fileLocation))) {
                
                while (!reader.EndOfStream) {

                    try {
                            
                        var user = load(reader.ReadLine()?.Split(','));

                        output.Add(user);
                            
                    } catch (Exception e) {
                            
                        Console.WriteLine(e.Message);
                            
                    }
                }
                
            }
            return output;
        }
        
        private Guest LoadGuest(string[] input) {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (input.Length != 7) throw new ArgumentException($@"Input array must be of length 7. '{string.Join(",", input)}'", nameof(input));
            return new Guest(input[0], input[1], input[2], input[3], DateTime.ParseExact(input[4], Constants.DateTimeFormat, DateTimeFormatInfo.CurrentInfo), int.Parse(input[5]), double.Parse(input[6]));
        }

        private Admin LoadAdmin(string[] input) {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (input.Length != 7) throw new ArgumentException($@"Input array must be of length 7. '{string.Join(",", input)}'", nameof(input));
            if (!Enum.TryParse<Admin.AdminType>(input[4], out var type)) throw new InvalidEnumArgumentException(@"Unable to parse admin type.");
            return new Admin(input[0], input[1], input[2], input[3], type, int.Parse(input[5]), double.Parse(input[6]));
        }

    }

    internal static class DictionaryExtension {

        public static TValue LazyGet<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Lazy<TValue> lazy) {
            TValue value;
            if (!dictionary.ContainsKey(key))
                dictionary[key] = value = lazy.Value;
            else
                value = dictionary[key];
            return value;
        }

    }

}