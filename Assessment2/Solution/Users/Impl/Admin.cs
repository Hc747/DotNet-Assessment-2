namespace Assessment2.Solution.Users.Impl {

    public class Admin : Abs.User {

        public enum AdminType {

            SuperAdmin,
            Moderator

        }

        private AdminType _adminType;

        public Admin(string username, string password, string firstName, string lastName, AdminType adminType, int ratingsCount, double averageRating) : base(
            username, password, firstName, lastName, ratingsCount, averageRating) {
            _adminType = adminType;
        }

        protected override string GetSerializableString()
            => $"{username},{password},{firstName},{lastName},{_adminType},{ratingsCount},{averageRating}";

        public override string GetFullUserString()
            => $"{username}: {firstName} {lastName}, {_adminType}";

    }

}