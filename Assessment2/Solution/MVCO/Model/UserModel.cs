using Assessment2.Solution.Users.Abs;
using Assessment2.Solution.Users.Impl;

namespace Assessment2.Solution.MVCO.Model {

    public class UserModel {

        private readonly User _observer;

        public UserModel(User observer, User observed) {
            _observer = observer;
            Observed = observed;
        }

        public string Info => _observer is Admin ? Observed.GetFullUserString() : Observed.GetShortUserString();

        public double AverageRating => Observed.AverageRating;

        public int RatingsCount => Observed.RatingsCount;

        public User Observed { get; }

    }

}