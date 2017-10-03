using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Assessment2.Solution;

namespace Assessment2
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private const string UsernameAndPasswordRegex = "^[a-zA-Z0-9]{2,}$";

        private void UsernameAndPassword_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textbox)) return;
            
            var regex = new Regex(UsernameAndPasswordRegex);

            var valid = regex.IsMatch(textbox.Text);

            textbox.ForeColor = valid ? Constants.TextValid : Constants.TextInvalid;
        }
    }
}
