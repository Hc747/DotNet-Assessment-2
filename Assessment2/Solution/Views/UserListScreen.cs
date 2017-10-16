using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Assessment2.Solution.Users;
using Assessment2.Solution.Users.Abs;
using Assessment2.Solution.Users.Impl;
using Assessment2.Solution.Views.Dialogues;
using MetroFramework.Forms;

namespace Assessment2.Solution.Views {

    public partial class UserListScreen : MetroForm {

        private readonly Form _parent;
        private readonly UserHandler _handler;

        /// <summary>
        /// Indiciates whether or not to exit the application upon the form closing
        /// When True:
        ///     show the parent form
        /// When False:
        ///     Invoke Application#Exit
        /// </summary>
        private bool _closeRequested;

        public UserListScreen(Form parent, UserHandler handler) {
            _parent = parent;
            _handler = handler;
            InitializeComponent();

            var user = _handler.LoggedInUser;
            var admin = user is Admin;

            var info = new StringBuilder();

            info.AppendLine($@"Signed in as: {user.GetFullUserString()}.");
            info.AppendLine($@"Avg. Rating: {user.AverageRating}.");
            info.AppendLine($@"Total Ratings: {user.RatingsCount}.");

            info_label.Text = info.ToString();

            administration_button.Visible = administration_button.Enabled =
                admin && (user as Admin).Type == Admin.AdminType.SuperAdmin;

            administration_info_column.Visible = admin;
            guest_info_column.Visible = !administration_info_column.Visible;

            var source = new BindingSource {
                DataSource = _handler.Users
            };

            data_grid.DataSource = source;

            FormClosing += (sender, args) => {
                if (!_closeRequested)
                    Application.Exit();
            };
        }

        private void rating_button_Click(object sender, EventArgs e) {
            var users = GetSelectedUsers();

            if (users.Count <= 0) return;

            var dialogue = new RatingDialogue(users);

            dialogue.ShowDialog();
        }

        private void administration_button_Click(object sender, EventArgs e) {
            var users = GetSelectedUsers();

            if (users.Count <= 0) return;

            var dialogue = new AdministrationDialogue(_handler, users);

            dialogue.ShowDialog();
        }

        private void logout_button_Click(object sender, EventArgs e) {
            if (!_handler.Logout())
                throw new SystemException("Illegal state: must be signed in to access user list screen.");
            ShowParent();
        }

        private void ShowParent() {
            _closeRequested = true;
            
            _parent.Show();
            _parent.Location = Location;

            Close();
        }

        private List<User> GetSelectedUsers() {
            return (from user in (from DataGridViewRow row in data_grid.Rows
                        let checkbox = row.Cells[4] as DataGridViewCheckBoxCell
                        let selected = checkbox?.Value
                        where selected != null && (bool) selected
                        select row.DataBoundItem).OfType<User>()
                    select user)
                .ToList();
        }

        private void data_grid_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            var index = _handler.Users.IndexOf(_handler.LoggedInUser);

            if (index == e.RowIndex && e.ColumnIndex == data_grid.Rows[e.RowIndex].Cells.Count - 1) {
                var value = data_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if ((bool) value)
                    data_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
            }
        }

    }

}