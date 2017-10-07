using Assessment2.Solution.Users;

namespace Assessment2.Solution.MVCO.View
{
    public partial class UserListScreen : MetroFramework.Forms.MetroForm
    {
        
        public UserHandler Handler { get; }
        
        public UserListScreen(UserHandler handler)
        {
            Handler = handler;
            InitializeComponent();
        }

        private void UserListScreen_Load(object sender, System.EventArgs e)
        {
            //foreach (var user in Handler.Users) //TODO
              //  userBindingSource1.Add(user);
        }
    }
}
