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

        private void cancel_button_Click(object sender, System.EventArgs e)
        {

        }

        private void submit_button_Click(object sender, System.EventArgs e)
        {

        }
    }
}
