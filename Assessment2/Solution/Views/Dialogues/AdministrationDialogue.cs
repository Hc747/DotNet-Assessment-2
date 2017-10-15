using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Assessment2.Solution.Users;
using Assessment2.Solution.Users.Abs;
using Assessment2.Solution.Users.Impl;
using System.Collections.ObjectModel;

namespace Assessment2.Solution.Views.Dialogues {

    public partial class AdministrationDialogue : MetroFramework.Forms.MetroForm {

        private readonly UserHandler _handler;
        private readonly ReadOnlyCollection<User> _users;

        public AdministrationDialogue(UserHandler handler, List<User> users) {
            _handler = handler;
            _users = new ReadOnlyCollection<User>(users);
            InitializeComponent();

            admin_values.DataSource = Enum.GetNames(typeof(Admin.AdminType));
            info_label.Text = $@"You are modifying the rank of {users.Count} user(s).";
        }

        private void login_button_Click(object sender, EventArgs e) {
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