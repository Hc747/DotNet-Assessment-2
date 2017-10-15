using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Assessment2.Solution.Users;
using Assessment2.Solution.Users.Abs;

namespace Assessment2.Solution.Views.Dialogues {

    public partial class RatingDialogue : MetroFramework.Forms.MetroForm {

        private readonly UserHandler _handler;
        private readonly ReadOnlyCollection<User> _users;

        public RatingDialogue(UserHandler handler, List<User> users) {
            _handler = handler;
            _users = new ReadOnlyCollection<User>(users);
            InitializeComponent();
            login_button.Enabled = false;
        }

        private void submit_button_Click(object sender, EventArgs e) {
            Close(); //TODO
        }

        private void cancel_button_Click(object sender, EventArgs e) {
            Close();
        }

    }

}