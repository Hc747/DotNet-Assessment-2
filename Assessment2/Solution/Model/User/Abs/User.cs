using System;
using System.IO;

namespace Assessment2.Solution.Model.User.Abs {

    public abstract class User {

        protected string Username, Password, FirstName, LastName;
        protected int RatingsCount;
        protected double AverageRating;

        protected User(string username, string password, string firstName, string lastName) {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        public bool CheckUsernameAndPassword(string username, string password)
            => Username == username && Password == password;

        public string GetShortUserString()
            => $"{Username}: {FirstName}";

        public void AddRating(int rating) {
            //TODO: check bounds
            throw new NotImplementedException("Add Rating");
        }

        public bool WriteToFile(StreamWriter writer) {
            try {
                writer.WriteLine(GetSerializableString());
                return true;
            } catch (Exception e) {
                Console.WriteLine($"Error writing user: {GetShortUserString()} to file: {e.Message}");
            }
            return false;
        }

        public string GetFileLocation()
            //TODO: file seperator char
            => $"./Data/{GetType().Name}.txt";

        protected abstract string GetSerializableString();

        public abstract string GetFullUserString();

    }

}