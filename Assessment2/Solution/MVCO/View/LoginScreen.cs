﻿using System;
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
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //TODO: validate
            //TODO: show UserListScreen or show error message
            var success = _validator.Validate(username, username.Text) &&
                          _validator.Validate(password, password.Text);

            if (!success) {
                MessageBox.Show(@"Your username and password must be atleast two characters long, and may only contain alphanumeric characters.");  
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

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
