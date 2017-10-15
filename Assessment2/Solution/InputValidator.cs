using System.Drawing;
using System.Windows.Forms;

namespace Assessment2.Solution {

    public class InputValidator {

        private readonly Color _valid, _invalid;
        private readonly Predicate _predicate;

        public InputValidator(Predicate predicate)
            : this(predicate, Constants.Valid, Constants.Invalid) { }

        public InputValidator(Predicate predicate, Color valid, Color invalid) {
            _predicate = predicate;
            _valid = valid;
            _invalid = invalid;
        }

        public bool Validate(Control control, string input) {
            var success = _predicate(input);

            control.ForeColor = success ? _valid : _invalid;

            return success;
        }

        public delegate bool Predicate(string input);

    }

}