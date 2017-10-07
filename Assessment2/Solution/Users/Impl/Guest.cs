using System;
using System.Globalization;

namespace Assessment2.Solution.Users.Impl {

    public class Guest : Abs.User {

        private readonly DateTime _dateOfBirth;

        public Guest(string username, string password, string firstName, string lastName, DateTime dateOfBirth, int ratingsCount, double averageRating) 
            : base(username, password, firstName, lastName, ratingsCount, averageRating) {
            _dateOfBirth = dateOfBirth;
        }

        protected override string GetSerializableString()
            => $"{username},{password},{firstName},{lastName},{_dateOfBirth.ToString("dd-mm-yyyy", CultureInfo.InvariantCulture)},{ratingsCount},{averageRating}";

        public override string GetFullUserString()
            => $"{firstName} {lastName}, {_dateOfBirth.ToShortDateString()}";

    }

}