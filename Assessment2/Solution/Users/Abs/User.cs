using System;
using System.IO;

namespace Assessment2.Solution.Users.Abs {

    public abstract class User {

        protected string username, password, firstName, lastName;
        protected int ratingsCount;
        protected double averageRating;

        protected User(string username, string password, string firstName, string lastName, int ratingsCount, double averageRating) {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.ratingsCount = ratingsCount;
            this.averageRating = averageRating;
        }

        public bool CheckUsernameAndPassword(string username, string password)
            => this.username == username && this.password == password;

        public string GetShortUserString()
            => $"{username}: {firstName}";

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