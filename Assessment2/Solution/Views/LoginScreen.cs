﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Assessment2.Solution.Users;

namespace Assessment2.Solution.Views {

    public partial class LoginScreen : MetroFramework.Forms.MetroForm {

        private readonly UserHandler _handler;

        private readonly InputValidator _validator =
            new InputValidator(input => new Regex(Constants.UsernameAndPasswordRegex).IsMatch(input));

        public LoginScreen(UserHandler handler) {
            _handler = handler;
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

        private void username_TextChanged(object sender, EventArgs e) {
            ForceValidate();
        }

        private void password_TextChanged(object sender, EventArgs e) {
            ForceValidate();
        }

        private void ForceValidate() {
            login_button.Enabled = _validator.Validate(username, username.Text) &&
                                   _validator.Validate(password, password.Text);
        }

    }

}