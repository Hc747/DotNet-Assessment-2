using Assessment2.Solution.Model;

namespace Assessment2
{
    public partial class RegistrationScreen : MetroFramework.Forms.MetroForm
    {
        
        public UserHandler Handler { get; }

        public RegistrationScreen(UserHandler handler) {
            Handler = handler;
            InitializeComponent();
        }
    }
}
