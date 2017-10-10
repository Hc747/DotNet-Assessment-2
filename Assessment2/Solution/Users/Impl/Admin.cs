using Assessment2.Solution.Users.Abs;

namespace Assessment2.Solution.Users.Impl {

    public class Admin : User {

        public enum AdminType {

            SuperAdmin,
            Moderator

        }

        public AdminType Type { get; protected set; }

        public Admin(string username, string password, string firstName, string lastName, AdminType type, int ratingsCount = 0, double averageRating = 0) 
            : base(username, password, firstName, lastName, ratingsCount, averageRating) {
            Type = type;
        }

        public Admin(User user, AdminType adminType) 
            : this(user.Username, user.Password, user.FirstName, user.LastName, adminType, user.RatingsCount, user.AverageRating) {}

        protected override string GetSerializableString()
            => $"{Username},{Password},{FirstName},{LastName},{Type},{RatingsCount},{AverageRating}";

        public override string GetFullUserString()
            => $"{Username}: {FirstName} {LastName}, {Type}";

    }

}