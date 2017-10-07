namespace Assessment2
{
    partial class RegistrationScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel register_container;
            MetroFramework.Controls.MetroLabel register_label;
            System.Windows.Forms.TableLayoutPanel username_and_password_container;
            System.Windows.Forms.TableLayoutPanel first_and_last_name_container;
            System.Windows.Forms.TableLayoutPanel button_container;
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.lastname = new MetroFramework.Controls.MetroTextBox();
            this.firstname = new MetroFramework.Controls.MetroTextBox();
            this.submit_button = new MetroFramework.Controls.MetroButton();
            this.cancel_button = new MetroFramework.Controls.MetroButton();
            this.birthday = new MetroFramework.Controls.MetroDateTime();
            register_container = new System.Windows.Forms.TableLayoutPanel();
            register_label = new MetroFramework.Controls.MetroLabel();
            username_and_password_container = new System.Windows.Forms.TableLayoutPanel();
            first_and_last_name_container = new System.Windows.Forms.TableLayoutPanel();
            button_container = new System.Windows.Forms.TableLayoutPanel();
            register_container.SuspendLayout();
            username_and_password_container.SuspendLayout();
            first_and_last_name_container.SuspendLayout();
            button_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_container
            // 
            register_container.ColumnCount = 1;
            register_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            register_container.Controls.Add(register_label, 0, 0);
            register_container.Controls.Add(username_and_password_container, 0, 1);
            register_container.Controls.Add(first_and_last_name_container, 0, 2);
            register_container.Controls.Add(button_container, 0, 4);
            register_container.Controls.Add(this.birthday, 0, 3);
            register_container.Location = new System.Drawing.Point(0, 31);
            register_container.Name = "register_container";
            register_container.RowCount = 5;
            register_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            register_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            register_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            register_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            register_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            register_container.Size = new System.Drawing.Size(240, 309);
            register_container.TabIndex = 5;
            // 
            // register_label
            // 
            register_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            register_label.AutoSize = true;
            register_label.Location = new System.Drawing.Point(48, 21);
            register_label.Name = "register_label";
            register_label.Size = new System.Drawing.Size(143, 19);
            register_label.TabIndex = 5;
            register_label.Text = "Register a new account";
            register_label.UseCustomBackColor = true;
            register_label.UseCustomForeColor = true;
            // 
            // username_and_password_container
            // 
            username_and_password_container.ColumnCount = 1;
            username_and_password_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            username_and_password_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            username_and_password_container.Controls.Add(this.username, 0, 0);
            username_and_password_container.Controls.Add(this.password, 0, 1);
            username_and_password_container.Location = new System.Drawing.Point(3, 64);
            username_and_password_container.Name = "username_and_password_container";
            username_and_password_container.RowCount = 2;
            username_and_password_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            username_and_password_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            username_and_password_container.Size = new System.Drawing.Size(234, 86);
            username_and_password_container.TabIndex = 1;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.username.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username.CustomButton.Image = null;
            this.username.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.username.CustomButton.Name = "";
            this.username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.CustomButton.TabIndex = 1;
            this.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username.CustomButton.UseSelectable = true;
            this.username.CustomButton.Visible = false;
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(35, 10);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PromptText = "Username";
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.ShortcutsEnabled = true;
            this.username.Size = new System.Drawing.Size(164, 23);
            this.username.TabIndex = 1;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.UseCustomBackColor = true;
            this.username.UseCustomForeColor = true;
            this.username.UseSelectable = true;
            this.username.WaterMark = "Username";
            this.username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(35, 53);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.PromptText = "Password";
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(164, 23);
            this.password.TabIndex = 2;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseCustomBackColor = true;
            this.password.UseCustomForeColor = true;
            this.password.UseSelectable = true;
            this.password.UseSystemPasswordChar = true;
            this.password.WaterMark = "Password";
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // first_and_last_name_container
            // 
            first_and_last_name_container.ColumnCount = 2;
            first_and_last_name_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            first_and_last_name_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            first_and_last_name_container.Controls.Add(this.lastname, 1, 0);
            first_and_last_name_container.Controls.Add(this.firstname, 0, 0);
            first_and_last_name_container.Location = new System.Drawing.Point(3, 156);
            first_and_last_name_container.Name = "first_and_last_name_container";
            first_and_last_name_container.RowCount = 1;
            first_and_last_name_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            first_and_last_name_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            first_and_last_name_container.Size = new System.Drawing.Size(234, 40);
            first_and_last_name_container.TabIndex = 2;
            // 
            // lastname
            // 
            this.lastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.lastname.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastname.CustomButton.Image = null;
            this.lastname.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.lastname.CustomButton.Name = "";
            this.lastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastname.CustomButton.TabIndex = 1;
            this.lastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastname.CustomButton.UseSelectable = true;
            this.lastname.CustomButton.Visible = false;
            this.lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lastname.Lines = new string[0];
            this.lastname.Location = new System.Drawing.Point(120, 8);
            this.lastname.MaxLength = 32767;
            this.lastname.Name = "lastname";
            this.lastname.PasswordChar = '\0';
            this.lastname.PromptText = "Last Name";
            this.lastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastname.SelectedText = "";
            this.lastname.SelectionLength = 0;
            this.lastname.SelectionStart = 0;
            this.lastname.ShortcutsEnabled = true;
            this.lastname.Size = new System.Drawing.Size(79, 23);
            this.lastname.TabIndex = 2;
            this.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastname.UseCustomBackColor = true;
            this.lastname.UseCustomForeColor = true;
            this.lastname.UseSelectable = true;
            this.lastname.WaterMark = "Last Name";
            this.lastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // firstname
            // 
            this.firstname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.firstname.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstname.CustomButton.Image = null;
            this.firstname.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.firstname.CustomButton.Name = "";
            this.firstname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.firstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstname.CustomButton.TabIndex = 1;
            this.firstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstname.CustomButton.UseSelectable = true;
            this.firstname.CustomButton.Visible = false;
            this.firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.firstname.Lines = new string[0];
            this.firstname.Location = new System.Drawing.Point(35, 8);
            this.firstname.MaxLength = 32767;
            this.firstname.Name = "firstname";
            this.firstname.PasswordChar = '\0';
            this.firstname.PromptText = "First Name";
            this.firstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstname.SelectedText = "";
            this.firstname.SelectionLength = 0;
            this.firstname.SelectionStart = 0;
            this.firstname.ShortcutsEnabled = true;
            this.firstname.Size = new System.Drawing.Size(79, 23);
            this.firstname.TabIndex = 1;
            this.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstname.UseCustomBackColor = true;
            this.firstname.UseCustomForeColor = true;
            this.firstname.UseSelectable = true;
            this.firstname.WaterMark = "First Name";
            this.firstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button_container
            // 
            button_container.ColumnCount = 2;
            button_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            button_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            button_container.Controls.Add(this.submit_button, 1, 0);
            button_container.Controls.Add(this.cancel_button, 0, 0);
            button_container.Location = new System.Drawing.Point(3, 248);
            button_container.Name = "button_container";
            button_container.RowCount = 1;
            button_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            button_container.Size = new System.Drawing.Size(234, 58);
            button_container.TabIndex = 6;
            // 
            // submit_button
            // 
            this.submit_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.submit_button.Location = new System.Drawing.Point(120, 17);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(79, 23);
            this.submit_button.TabIndex = 5;
            this.submit_button.Text = "Submit";
            this.submit_button.UseCustomBackColor = true;
            this.submit_button.UseCustomForeColor = true;
            this.submit_button.UseSelectable = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancel_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.cancel_button.Location = new System.Drawing.Point(35, 17);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(79, 23);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseCustomBackColor = true;
            this.cancel_button.UseCustomForeColor = true;
            this.cancel_button.UseSelectable = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // birthday
            // 
            this.birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthday.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.birthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.birthday.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.birthday.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.birthday.Location = new System.Drawing.Point(38, 207);
            this.birthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(164, 29);
            this.birthday.TabIndex = 3;
            this.birthday.UseCustomBackColor = true;
            this.birthday.UseCustomForeColor = true;
            // 
            // RegistrationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 340);
            this.Controls.Add(register_container);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 340);
            this.MinimumSize = new System.Drawing.Size(240, 340);
            this.Name = "RegistrationScreen";
            this.Opacity = 0.8D;
            this.Resizable = false;
            this.ShowIcon = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            register_container.ResumeLayout(false);
            register_container.PerformLayout();
            username_and_password_container.ResumeLayout(false);
            first_and_last_name_container.ResumeLayout(false);
            button_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton submit_button;
        private MetroFramework.Controls.MetroTextBox username;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroButton cancel_button;
        private MetroFramework.Controls.MetroTextBox lastname;
        private MetroFramework.Controls.MetroTextBox firstname;
        private MetroFramework.Controls.MetroDateTime birthday;
    }
}