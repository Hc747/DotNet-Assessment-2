using System;
using System.IO;

namespace Assessment2.Solution.Users.Abs {

    public abstract class User {
        
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public int RatingsCount { get; protected set; }
        public double AverageRating { get; protected set; }

        protected User(string username, string password, string firstName, string lastName, int ratingsCount, double averageRating) {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            RatingsCount = ratingsCount;
            AverageRating = averageRating;
        }

        public bool CheckUsernameAndPassword(string username, string password)
            => Username == username && Password == password;

        public void AddRating(int rating) { //TODO: update
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

        public override bool Equals(object obj) {
            return obj is User other && other.Username == Username;
        }

        public string GetShortUserString()
            => $"{Username}: {FirstName}";
        
        public abstract string GetFullUserString();

        protected abstract string GetSerializableString();

    }

}