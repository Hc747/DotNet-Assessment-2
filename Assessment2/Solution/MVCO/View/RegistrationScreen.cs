﻿using System.Text.RegularExpressions;
using System.Windows.Forms;
using Assessment2.Solution.Users;
using Assessment2.Solution.Users.Impl;

namespace Assessment2.Solution.MVCO.View
{
    public partial class RegistrationScreen : MetroFramework.Forms.MetroForm {

        private readonly Form _parent;
        private readonly UserHandler _handler;
        private readonly InputValidator _usernameAndPasswordValidator = new InputValidator(input => new Regex(Constants.UsernameAndPasswordRegex).IsMatch(input));
        private readonly InputValidator _firstAndLastNameValidator = new InputValidator(input => new Regex(Constants.FirstAndLastNameRegex).IsMatch(input));

        public RegistrationScreen(Form parent, UserHandler handler) {
            _parent = parent;
            _handler = handler;
            InitializeComponent();
            submit_button.Enabled = false;
        }

        private void cancel_button_Click(object sender, System.EventArgs e)
        {
            ShowParent();
        }

        private void submit_button_Click(object sender, System.EventArgs e)
        {
            var user = new Guest(username.Text, password.Text, firstname.Text, lastname.Text, birthday.Value, 0, 0);
            
            if (!_handler.AddUser(user, out var error)) {
                MessageBox.Show(error);
                return;
            }
            
            ShowParent();
        }

        private void ShowParent() {
            _parent.Show();
            _parent.Location = Location;
            
            Close();
        }

        private void username_TextChanged(object sender, System.EventArgs e)
        {
            ForceValidate();
        }

        private void password_TextChanged(object sender, System.EventArgs e)
        {
            ForceValidate();
        }

        private void firstname_TextChanged(object sender, System.EventArgs e)
        {
            ForceValidate();
        }

        private void lastname_TextChanged(object sender, System.EventArgs e)
        {
            ForceValidate();
        }

        private void ForceValidate() {
            submit_button.Enabled = _usernameAndPasswordValidator.Validate(username, username.Text) &&
                                    _usernameAndPasswordValidator.Validate(password, password.Text) &&
                                    _firstAndLastNameValidator.Validate(firstname, firstname.Text) &&
                                    _firstAndLastNameValidator.Validate(lastname, lastname.Text);
        }
        
    }
}
