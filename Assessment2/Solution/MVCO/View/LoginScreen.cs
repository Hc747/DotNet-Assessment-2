using System;
using System.Windows.Forms;
using Assessment2.Solution.Users;

namespace Assessment2.Solution.MVCO.View
{
    public partial class LoginScreen : MetroFramework.Forms.MetroForm {

        private readonly UserHandler _handler;
        
        public LoginScreen(UserHandler handler) {
            _handler = handler;
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //TODO: validate
            //TODO: show UserListScreen or show error message
            Application.Run(new UserListScreen(_handler));
            
            Close();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            var registration = new RegistrationScreen(this, _handler);
            
            registration.Show();
            registration.Location = Location;
            
            Hide();
        }
    }
}
