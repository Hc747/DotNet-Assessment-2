using System;
using System.Windows.Forms;

namespace Assessment2.Solution.View.Components {

    public class PlaceholderTextBox : TextBox {

        private readonly string _placeholder;
        private bool _password;

        public PlaceholderTextBox(string placehodler) {
            _placeholder = placehodler;
            LostFocus += OnLostFocus;
            GotFocus += OnGotFocus;
        }

        private void OnLostFocus(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(Text))
                Text = _placeholder;
            if (UseSystemPasswordChar) {
                _password = true;
                UseSystemPasswordChar = false;
            }
        }

        private void OnGotFocus(object sender, EventArgs e) {
            if (_placeholder == Text)
                Text = string.Empty;
            if (_password) {
                UseSystemPasswordChar = true;
            }
        }

    }

}