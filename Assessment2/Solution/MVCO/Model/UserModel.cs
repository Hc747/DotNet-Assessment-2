using Assessment2.Solution.Users.Abs;
using Assessment2.Solution.Users.Impl;

namespace Assessment2.Solution.MVCO.Model {

    public class UserModel {

        public UserModel(User observer, User observed) {
            Observer = observer;
            Observed = observed;
        }

        public string Info => Observer is Admin ? Observed.GetFullUserString() : Observed.GetShortUserString();

        public double AverageRating => Observed.AverageRating;

        public int RatingsCount => Observed.RatingsCount;

        public User Observed { get; }
        
        public User Observer { get; }

    }

}