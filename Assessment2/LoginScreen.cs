using System;
using Assessment2.Solution.Model;

namespace Assessment2
{
    public partial class LoginScreen : MetroFramework.Forms.MetroForm
    {
        
        public UserHandler Handler { get; } = new UserHandler();
        
        public LoginScreen()
        {
            if (!Handler.LoadAllUsers())
                throw new NotImplementedException("TODO");
            
            InitializeComponent();
        }
    }
}
