using Assessment2.Solution.Model;

namespace Assessment2
{
    public partial class UserListScreen : MetroFramework.Forms.MetroForm
    {
        
        public UserHandler Handler { get; }
        
        public UserListScreen(UserHandler handler)
        {
            Handler = handler;
            InitializeComponent();
        }
    }
}
