using Assessment2.Solution.Users;
using System.Windows.Forms;

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

            info_label.Text = $@"Signed in as: {_handler.LoggedInUser.GetFullUserString()}.";
        }

        private void UserListScreen_Load(object sender, System.EventArgs e)
        {
            //foreach (var user in Handler.Users) //TODO
              //  userBindingSource1.Add(user);
        }

        private void rating_button_Click(object sender, System.EventArgs e)
        {

        }

        private void administration_button_Click(object sender, System.EventArgs e)
        {

        }
    }
}
