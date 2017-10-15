using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Assessment2.Solution.Users;
using Assessment2.Solution.Users.Abs;

namespace Assessment2.Solution.Views.Dialogues {

    public partial class RatingDialogue : MetroFramework.Forms.MetroForm {

        private readonly UserHandler _handler;
        private readonly List<User> _users;

        public RatingDialogue(UserHandler handler, List<User> users) {
            _handler = handler;
            _users = users;
            InitializeComponent();
            login_button.Enabled = false;
        }

        private void login_button_Click(object sender, EventArgs e) {
            if (!_handler.Login(username.Text, password.Text)) {
                MessageBox.Show(@"Incorrect username or password.");
                return;
            }
            
            password.Text = string.Empty;

            var users = new UserListScreen(this, _handler);

            users.Show();
            users.Location = Location;

            Hide();
        }

        private void register_button_Click(object sender, EventArgs e) {
            var registration = new RegistrationScreen(this, _handler);

            registration.Show();
            registration.Location = Location;

            Hide();
        }

    }

}