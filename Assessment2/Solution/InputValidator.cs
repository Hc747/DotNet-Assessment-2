using System.Drawing;
using System.Windows.Forms;

namespace Assessment2.Solution {

    public class InputValidator {

        /// <summary>
        /// The color objects to display when the input is valid or invalid.
        /// </summary>
        private readonly Color _valid, _invalid;
        private readonly ValidationPredicate _validationPredicate;

        public InputValidator(ValidationPredicate validationPredicate)
            : this(validationPredicate, Constants.Valid, Constants.Invalid) { }

        public InputValidator(ValidationPredicate validationPredicate, Color valid, Color invalid) {
            _validationPredicate = validationPredicate;
            _valid = valid;
            _invalid = invalid;
        }

        /// <summary>
        /// Validates the input provided and provides visual feedback 
        /// (by changing the ForeColor of the parameterised control)
        /// in order to allow the user to know whether or not the provided
        /// input was valid.
        /// </summary>
        /// <param name="control">
        /// The control to change the ForeColor of.
        /// </param>
        /// <param name="input">
        /// The input to validate.
        /// </param>
        /// <returns>
        /// whether or not the input is valid.
        /// </returns>
        public bool Validate(Control control, string input) {
            var success = _validationPredicate(input);

            control.ForeColor = success ? _valid : _invalid;

            return success;
        }

        //delegate method for validating
        public delegate bool ValidationPredicate(string input);

    }

}