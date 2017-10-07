using System.Windows.Forms;
using Assessment2.Solution.Users;

namespace Assessment2.Solution.MVCO.View
{
    public partial class RegistrationScreen : MetroFramework.Forms.MetroForm {

        private readonly Form _parent;
        private readonly UserHandler _handler;

        public RegistrationScreen(Form parent, UserHandler handler) {
            _parent = parent;
            _handler = handler;
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, System.EventArgs e)
        {
            ReturnToParent();
        }

        private void submit_button_Click(object sender, System.EventArgs e)
        {
            //TODO: validate
            //TODO: add new user or show error message
            //TODO: show success message
            //ReturnToParent();
        }

        private void ReturnToParent() {
            _parent.Show();
            Close();
        }

    }
}
