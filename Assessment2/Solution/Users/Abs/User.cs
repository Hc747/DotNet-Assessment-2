using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Assessment2.Annotations;

namespace Assessment2.Solution.Users.Abs {

    public abstract class User : INotifyPropertyChanged {

        private string _username, _password, _firstName, _lastName;
        private int _ratingsCount;
        private double _averageRating;
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Username {
            get => _username;
            protected set {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Password {
            get => _password;
            protected set {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string FirstName {
            get => _firstName;
            protected set {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName {
            get => _lastName;
            protected set {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public int RatingsCount {
            get => _ratingsCount;
            protected set {
                _ratingsCount = value;
                OnPropertyChanged();
            }
        }

        public double AverageRating {
            get => _averageRating;
            protected set {
                _averageRating = value;
                OnPropertyChanged();
            }
        }

        public string FullInfo => GetFullUserString();
        
        public string ShortInfo => GetShortUserString();

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

        public void AddRating(int rating) 
            => AverageRating = (rating + AverageRating * RatingsCount) / ++RatingsCount;

        public bool WriteToFile(StreamWriter writer) {
            try {
                writer.WriteLine(GetSerializableString());
                return true;
            } catch (Exception e) {
                Console.WriteLine($"Error writing user: {GetShortUserString()} to file: {e.Message}");
            }
            return false;
        }

        public string GetFileLocation() {
            return Path.Combine("Data", GetType().Name + ".txt");
        }

        public override bool Equals(object obj) {
            return obj is User other && other.Username == Username;
        }

        public string GetShortUserString()
            => $"{Username}: {FirstName}";
        
        public abstract string GetFullUserString();

        protected abstract string GetSerializableString();

    }

}