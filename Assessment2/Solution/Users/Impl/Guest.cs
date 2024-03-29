﻿using System;
using Assessment2.Solution.Users.Abs;

namespace Assessment2.Solution.Users.Impl {

    public class Guest : User {

        private DateTime _dateOfBirth;

        public DateTime DateOfBirth {
            get => _dateOfBirth;
            protected set {
                _dateOfBirth = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        //usage of default arguments allows the constructor to be called without all of the required arguments
        public Guest(string username, string password, string firstName, string lastName, DateTime dateOfBirth,
            int ratingsCount = 0, double averageRating = 0)
            : base(username, password, firstName, lastName, ratingsCount, averageRating) {
            DateOfBirth = dateOfBirth;
        }

        protected override string GetSerializableString()
            =>
                $"{Username},{Password},{FirstName},{LastName},{DateOfBirth.ToString(Constants.DateTimeFormat)},{RatingsCount},{AverageRating}";

        public override string GetFullUserString()
            => $"{FirstName} {LastName}, {DateOfBirth.ToString(Constants.DateTimeFormat)}";

    }

}