using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Assessment2.Solution.Users;

namespace Assessment2.Solution.MVCO.View
{
    public partial class LoginScreen : MetroFramework.Forms.MetroForm {

        private const string RegexPattern = "[a-zA-Z0-9]{2,}";

        private readonly UserHandler _handler;
        private readonly InputValidator _validator = new InputValidator(input => new Regex(RegexPattern).IsMatch(input));
        
        public LoginScreen(UserHandler handler) {
            _handler = handler;
            InitializeComponent();
            login_button.Enabled = false;
        }

        //TODO: explain preconditions
        private void login_button_Click(object sender, EventArgs e)
        {
            if (!_handler.Login(username.Text, password.Text)) {
                MessageBox.Show(@"Incorrect username or password.");
                return;
            }

            var users = new UserListScreen(this, _handler);

            users.Show();
            users.Location = Location;

            Hide();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            var registration = new RegistrationScreen(this, _handler);
            
            registration.Show();
            registration.Location = Location;
            
            Hide();
        }

        private void username_TextChanged(object sender, EventArgs e) {
            OnTextChange();
        }

        private void password_TextChanged(object sender, EventArgs e) {
            OnTextChange();
        }

        private void OnTextChange() {
            login_button.Enabled = _validator.Validate(username, username.Text) &&
                                   _validator.Validate(password, password.Text);
        }
    }
}
