using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assessment2
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private static readonly Color InputValid = Color.FromArgb(175, 177, 190);
        private static readonly Color InputInvalid = Color.FromArgb(220, 97, 128);

        private const string UsernameAndPasswordRegex = "^[a-zA-Z0-9]{2,}$";

        private void Username_or_password_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textbox)
            {
                var regex = new Regex(UsernameAndPasswordRegex);

                var valid = regex.IsMatch(textbox.Text);

                textbox.ForeColor = valid ? InputValid : InputInvalid;
            }
        }
    }
}
