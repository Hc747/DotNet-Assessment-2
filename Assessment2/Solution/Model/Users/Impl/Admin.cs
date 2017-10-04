namespace Assessment2.Solution.Model.Users.Impl {

    public class Admin : Abs.User {

        public enum AdminType {

            SuperAdmin,
            Moderator

        }

        private AdminType _adminType;

        public Admin(string username, string password, string firstName, string lastName, AdminType adminType) : base(
            username, password, firstName, lastName) {
            _adminType = adminType;
        }

        protected override string GetSerializableString()
            => $"{Username},{Password},{FirstName},{LastName},{_adminType},{RatingsCount},{AverageRating}";

        public override string GetFullUserString()
            => $"{Username}: {FirstName} {LastName}, {_adminType}";

    }

}