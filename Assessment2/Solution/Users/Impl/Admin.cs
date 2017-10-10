using Assessment2.Solution.Users.Abs;

namespace Assessment2.Solution.Users.Impl {

    public class Admin : User {

        public enum AdminType {

            SuperAdmin,
            Moderator

        }

        private AdminType _adminType;

        public Admin(string username, string password, string firstName, string lastName, AdminType adminType, int ratingsCount, double averageRating) 
            : base(username, password, firstName, lastName, ratingsCount, averageRating) {
            _adminType = adminType;
        }

        public Admin(User user, AdminType adminType) 
            : this(user.Username, user.Password, user.FirstName, user.LastName, adminType, user.RatingsCount, user.AverageRating) {}

        protected override string GetSerializableString()
            => $"{Username},{Password},{FirstName},{LastName},{_adminType},{RatingsCount},{AverageRating}";

        public override string GetFullUserString()
            => $"{Username}: {FirstName} {LastName}, {_adminType}";

    }

}