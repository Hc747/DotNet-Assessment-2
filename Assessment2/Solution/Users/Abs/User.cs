﻿using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Assessment2.Annotations;

namespace Assessment2.Solution.Users.Abs {

    public abstract class User : INotifyPropertyChanged {

        //the backing fields for the properties below
        private string _username, _password, _firstName, _lastName;

        private int _ratingsCount;
        private double _averageRating;

        //used to notify the any observers of an update being required
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Username {
            get => _username;
            protected set {
                _username = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullInfo));
                OnPropertyChanged(nameof(ShortInfo));
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
                OnPropertyChanged(nameof(FullInfo));
                OnPropertyChanged(nameof(ShortInfo));
            }
        }

        public string LastName {
            get => _lastName;
            protected set {
                _lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullInfo));
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
                _averageRating = Math.Round(value, 2);
                OnPropertyChanged();
            }
        }

        protected User(string username, string password, string firstName, string lastName, int ratingsCount,
            double averageRating) {
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

        //instead of WriteAdminToFile and WriteGuestToFile: allows for any child of the User class
        //to be serialised
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
            return Path.Combine(Constants.DataPath, GetType().Name + ".txt");
        }

        public override bool Equals(object obj) {
            return obj is User other && other.Username == Username;
        }

        //used for interfacing with the windows forms API
        public string FullInfo => GetFullUserString();

        //used for interfacing with the windows forms API
        public string ShortInfo => GetShortUserString();

        //required by the spec (should have used abstract properties)
        public string GetShortUserString()
            => $"{Username}: {FirstName}";

        //required by the spec (should have used abstract properties)
        public abstract string GetFullUserString();

        //the specifies the order of the fields to serialise
        protected abstract string GetSerializableString();

    }

}