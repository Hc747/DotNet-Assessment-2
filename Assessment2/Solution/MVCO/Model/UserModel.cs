namespace Assessment2.Solution.MVCO.Model {

    public class UserModel {

        private readonly string _info;
        private readonly double _average;
        private readonly int _count;

        public UserModel(string info, double average, int count) {
            _info = info;
            _average = average;
            _count = count;
        }

        public string Info => _info;

        public double Average => _average;

        public int Count => _count;
    }

}