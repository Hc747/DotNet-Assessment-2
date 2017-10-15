using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using Assessment2.Solution.Users;
using Assessment2.Solution.Users.Abs;
using MetroFramework.Controls;

namespace Assessment2.Solution.Views.Dialogues {

    public partial class RatingDialogue : MetroFramework.Forms.MetroForm {

        private readonly UserHandler _handler;
        private readonly ReadOnlyCollection<User> _users;

        public RatingDialogue(UserHandler handler, List<User> users) {
            _handler = handler;
            _users = new ReadOnlyCollection<User>(users);
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e) {
            var selected = button_container.Controls.OfType<MetroRadioButton>().Where(x => x.Checked).ToList();

            if (selected.Count == 1) {
                if (int.TryParse(selected[0].Text, out var rating)) {
                    foreach (var user in _users)
                        user.AddRating(rating);
                    
                    MessageBox.Show($@"Added a rating of '{rating}' to each user.");
                }
            }
            Close();
        }

        private void cancel_button_Click(object sender, EventArgs e) {
            Close();
        }
    }

}