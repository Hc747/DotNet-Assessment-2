using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using Assessment2.Solution.Users.Abs;
using Assessment2.Solution.Users.Impl;

namespace Assessment2.Solution.Users {

    public class UserHandler {

        //accessible by any object with reference to the UserHandler instance, however,
        //only mutable within this class.
        //no need for a backing field (_loggedInUser), as the property automatically provides one and
        //the logic behind the accessor and mutator is simplistic
        public User LoggedInUser { get; private set; }

        //a BindingList was chosen instead of a generic List as it wraps the List interface,
        //and provides a means of receiving events upon the data held in the list changing.
        public BindingList<User> Users { get; } = new BindingList<User>();

        //whenever the value of a property is changed in ANY User object, the handler containing
        //said user invokes #SaveAllUsers
        public T Initialise<T>(T user) where T : User {
            user.PropertyChanged += (sender, args) => SaveAllUsers();
            return user;
        }

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

            //intentional reassignment of the success variable, so that it may later be used as the return value
            error = (success = SaveAllUsers()) ? null : "An error occured while attempting to save all users.";

            return success;
        }

        public bool Replace(User current, User replacement, out string error) {
            var index = Users.IndexOf(current);

            var success = index > -1;

            if (!success) {
                error =
                    $"Unable to replace {current.GetShortUserString() ?? "null"} with {replacement.GetShortUserString() ?? "null"}";
                return false;
            }

            Users[index] = Initialise(replacement);

            //intentional reassignment of the success variable, so that it may later be used as the return value
            error = (success = SaveAllUsers()) ? null : "An error occured while attempting to save all users.";

            return success;
        }

        public bool LoadAllUsers() {
            try {
                var users = new List<User>();

                users.AddRange(Load(Path.Combine("Data", "Guest.txt"), UserLoader.LoadGuest));
                users.AddRange(Load(Path.Combine("Data", "Admin.txt"), UserLoader.LoadAdmin));

                //only mutate the collection if the above operations occurred successfully

                Users.Clear();

                foreach (var user in users)
                    Users.Add(Initialise(user));

                return true;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public bool SaveAllUsers() {
            var writers = new Dictionary<string, StreamWriter>();
            var success = true;

            const bool Append = false;

            foreach (var user in Users) {
                //find the real path of the data files
                var location = Path.Combine("..", "..", user.GetFileLocation());

                //only create one streamwriter per file path
                var writer = writers.LazyGet(location,
                    new Lazy<StreamWriter>(() => new StreamWriter(location, Append)));

                if (!user.WriteToFile(writer))
                    success = false;
            }

            //release all resources and close all files
            foreach (var writer in writers.Values) {
                try {
                    using (writer) { }
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }

            return success;
        }

        //Delegate method for deserialising User objects
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

    }

    //used for deserializing User objects
    internal static class UserLoader {

        internal static Admin LoadAdmin(string[] input) {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (input.Length != 7)
                throw new ArgumentException($@"Input array must be of length 7. '{string.Join(",", input)}'",
                    nameof(input));
            if (!Enum.TryParse<Admin.AdminType>(input[4], out var type))
                throw new InvalidEnumArgumentException(@"Unable to parse admin type.");
            return new Admin(input[0], input[1], input[2], input[3], type, int.Parse(input[5]), double.Parse(input[6]));
        }

        internal static Guest LoadGuest(string[] input) {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (input.Length != 7)
                throw new ArgumentException($@"Input array must be of length 7. '{string.Join(",", input)}'",
                    nameof(input));
            return new Guest(input[0], input[1], input[2], input[3],
                DateTime.ParseExact(input[4], Constants.DateTimeFormat, DateTimeFormatInfo.CurrentInfo),
                int.Parse(input[5]), double.Parse(input[6]));
        }

    }

    internal static class DictionaryExtension {

        //only initialise an instance of the type held by the Lazy object if it's not contained within the dictionary
        public static TValue LazyGet<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key,
            Lazy<TValue> lazy) {
            TValue value;
            if (!dictionary.ContainsKey(key))
                dictionary[key] = value = lazy.Value;
            else
                value = dictionary[key];
            return value;
        }

    }

}