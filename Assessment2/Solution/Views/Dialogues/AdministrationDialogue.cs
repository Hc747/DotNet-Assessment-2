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

        private void submit_button_Click(object sender, EventArgs e) {
            if (Enum.TryParse<Admin.AdminType>(admin_values.SelectedValue.ToString(), out var type)) {
                foreach (var user in _users) {
                    
                    var replacement = new Admin(user, type);

                    if (!_handler.Replace(user, replacement, out var error))
                        MessageBox.Show(error);
                    
                }

                MessageBox.Show($@"Updated the rank of all users to: '{admin_values.SelectedValue.ToString()}'.");
            }
            Close();
        }

        private void cancel_button_Click(object sender, EventArgs e) {
            Close();
        }
    }

}