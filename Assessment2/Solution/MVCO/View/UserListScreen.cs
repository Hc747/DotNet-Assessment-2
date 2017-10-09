using System;
using System.Collections.Generic;
using Assessment2.Solution.MVCO.Model;
using Assessment2.Solution.Users;
using Assessment2.Solution.Users.Impl;
using System.Windows.Forms;
using Assessment2.Solution.Users.Abs;

namespace Assessment2.Solution.MVCO.View
{
    public partial class UserListScreen : MetroFramework.Forms.MetroForm
    {

        private readonly Form _parent;
        private readonly UserHandler _handler;
        
        public UserListScreen(Form parent, UserHandler handler)
        {
            _parent = parent;
            _handler = handler;
            InitializeComponent();

            var user = _handler.LoggedInUser;

            info_label.Text = $@"Signed in as: {user.GetFullUserString()}.";
            administration_button.Visible = administration_button.Enabled = user is Admin;

        }

        private void UserListScreen_Load(object sender, System.EventArgs e)
        {
            foreach (var user in _handler.Users)
            {
                userModelBindingSource.Add(new UserModel(_handler.LoggedInUser, user));
            }
        }

        private void rating_button_Click(object sender, System.EventArgs e)
        {
            //TODO: make sure users are selected
            //TODO: make the interface modal
        }

        private void administration_button_Click(object sender, System.EventArgs e)
        {
            //TODO: make sure users are selected
            //TODO: make the interface modal
            var users = GetSelectedUsers();
            Console.WriteLine($@"{users.Count} users selected.");
            foreach (var user in users) {
                Console.WriteLine(user?.GetFullUserString());
            }
        }

        private List<User> GetSelectedUsers() {
            var output = new List<User>();

            foreach (DataGridViewRow row in data_grid.Rows) {
                var checkbox = row.Cells[3] as DataGridViewCheckBoxCell;

                var selected = checkbox?.Value;

                if (selected != null && (bool) selected) {
                    output.Add(row.DataBoundItem as User);
                }

            }
            
            return output;
        }
    }
}
