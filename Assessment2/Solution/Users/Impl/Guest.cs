using System;
using System.Globalization;
using Assessment2.Solution.Users.Abs;

namespace Assessment2.Solution.Users.Impl {

    public class Guest : User {

        public DateTime DateOfBirth { get; protected set; }

        public Guest(string username, string password, string firstName, string lastName, DateTime dateOfBirth, int ratingsCount = 0, double averageRating = 0) 
            : base(username, password, firstName, lastName, ratingsCount, averageRating) {
            DateOfBirth = dateOfBirth;
        }

        protected override string GetSerializableString()
            => $"{Username},{Password},{FirstName},{LastName},{DateOfBirth.ToString("dd-mm-yyyy", CultureInfo.InvariantCulture)},{RatingsCount},{AverageRating}";

        public override string GetFullUserString()
            => $"{FirstName} {LastName}, {DateOfBirth.ToShortDateString()}";

    }

}