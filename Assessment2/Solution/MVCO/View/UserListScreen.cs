using System.Collections.Generic;
using System.Linq;
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

            data_grid.DataSource = _handler.Users;
            _handler.Users.CollectionChanged += (sender, args) => data_grid.Refresh();
            data_grid.Refresh();

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

            foreach (var user in users) {
                var replacement = new Admin(user, Admin.AdminType.SuperAdmin);
                
                if (!_handler.Replace(user, replacement, out var error))
                    MessageBox.Show(error);
            }

            data_grid.Refresh();
        }

        private List<User> GetSelectedUsers() {
            return (from model in (from DataGridViewRow row in data_grid.Rows let checkbox = row.Cells[3] as DataGridViewCheckBoxCell let selected = checkbox?.Value where selected != null && (bool) selected select row.DataBoundItem).OfType<UserModel>() where !Equals(model.Observer, model.Observed) select model.Observed).ToList();
        }
    }
}
