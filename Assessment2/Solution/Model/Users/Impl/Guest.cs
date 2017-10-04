using System;
using System.Globalization;

namespace Assessment2.Solution.Model.Users.Impl {

    public class Guest : Abs.User {

        private readonly DateTime _dateOfBirth;

        public Guest(string username, string password, string firstName, string lastName, DateTime dateOfBirth) 
            : base(username, password, firstName, lastName) {
            _dateOfBirth = dateOfBirth;
        }

        protected override string GetSerializableString()
            => $"{Username},{Password},{FirstName},{LastName},{_dateOfBirth.ToString("dd-mm-yyyy", CultureInfo.InvariantCulture)},{RatingsCount},{AverageRating}";

        public override string GetFullUserString()
            => $"{FirstName} {LastName}, {_dateOfBirth}";

    }

}