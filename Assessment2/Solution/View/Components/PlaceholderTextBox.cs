using System;
using System.Windows.Forms;

namespace Assessment2.Solution.View.Components {

    public class PlaceholderTextBox : TextBox {

        private readonly string _placeholder;

        public PlaceholderTextBox(string placehodler) {
            _placeholder = placehodler;
            LostFocus += OnLostFocus;
            GotFocus += OnGotFocus;
        }

        private void OnLostFocus(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(Text))
                Text = _placeholder;
        }

        private void OnGotFocus(object sender, EventArgs e) {
            if (_placeholder == Text)
                Text = string.Empty;
        }

    }

}