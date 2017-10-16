using Assessment2.Solution.Users.Abs;

namespace Assessment2.Solution.Users.Impl {

    public class Admin : User {

        public enum AdminType {

            SuperAdmin,
            Moderator

        }

        private AdminType _type;

        public AdminType Type {
            get => _type;
            protected set {
                _type = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        //usage of default values allows for the constructor to be called without all of the required arguments
        public Admin(string username, string password, string firstName, string lastName, AdminType type,
            int ratingsCount = 0, double averageRating = 0)
            : base(username, password, firstName, lastName, ratingsCount, averageRating) {
            Type = type;
        }

        //used in creating an Admin object from any other User object.
        public Admin(User user, AdminType adminType)
            : this(user.Username, user.Password, user.FirstName, user.LastName, adminType, user.RatingsCount,
                user.AverageRating) { }

        protected override string GetSerializableString()
            => $"{Username},{Password},{FirstName},{LastName},{Type},{RatingsCount},{AverageRating}";

        public override string GetFullUserString()
            => $"{Username}: {FirstName} {LastName}, {Type}";

    }

}