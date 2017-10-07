namespace Assessment2
{
    partial class LoginScreen
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
            System.Windows.Forms.TableLayoutPanel login_container;
            MetroFramework.Controls.MetroLabel login_label;
            System.Windows.Forms.TableLayoutPanel textfield_container;
            System.Windows.Forms.TableLayoutPanel register_container;
            MetroFramework.Controls.MetroLabel register_label;
            this.login_button = new MetroFramework.Controls.MetroButton();
            this.login_username = new MetroFramework.Controls.MetroTextBox();
            this.login_password = new MetroFramework.Controls.MetroTextBox();
            this.register_button = new MetroFramework.Controls.MetroButton();
            login_container = new System.Windows.Forms.TableLayoutPanel();
            login_label = new MetroFramework.Controls.MetroLabel();
            textfield_container = new System.Windows.Forms.TableLayoutPanel();
            register_container = new System.Windows.Forms.TableLayoutPanel();
            register_label = new MetroFramework.Controls.MetroLabel();
            login_container.SuspendLayout();
            textfield_container.SuspendLayout();
            register_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_container
            // 
            login_container.ColumnCount = 1;
            login_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            login_container.Controls.Add(this.login_button, 0, 2);
            login_container.Controls.Add(login_label, 0, 0);
            login_container.Controls.Add(textfield_container, 0, 1);
            login_container.Controls.Add(register_container, 0, 3);
            login_container.Location = new System.Drawing.Point(0, 31);
            login_container.Name = "login_container";
            login_container.RowCount = 4;
            login_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            login_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            login_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            login_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            login_container.Size = new System.Drawing.Size(240, 309);
            login_container.TabIndex = 5;
            // 
            // login_button
            // 
            this.login_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_button.Location = new System.Drawing.Point(82, 187);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseCustomBackColor = true;
            this.login_button.UseCustomForeColor = true;
            this.login_button.UseSelectable = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_label
            // 
            login_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            login_label.AutoSize = true;
            login_label.Location = new System.Drawing.Point(38, 21);
            login_label.Name = "login_label";
            login_label.Size = new System.Drawing.Size(163, 19);
            login_label.TabIndex = 5;
            login_label.Text = "Already have an acccount?";
            login_label.UseCustomBackColor = true;
            login_label.UseCustomForeColor = true;
            // 
            // textfield_container
            // 
            textfield_container.ColumnCount = 1;
            textfield_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            textfield_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            textfield_container.Controls.Add(this.login_username, 0, 0);
            textfield_container.Controls.Add(this.login_password, 0, 1);
            textfield_container.Location = new System.Drawing.Point(3, 64);
            textfield_container.Name = "textfield_container";
            textfield_container.RowCount = 2;
            textfield_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            textfield_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            textfield_container.Size = new System.Drawing.Size(234, 86);
            textfield_container.TabIndex = 1;
            // 
            // login_username
            // 
            this.login_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.login_username.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_username.CustomButton.Image = null;
            this.login_username.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.login_username.CustomButton.Name = "";
            this.login_username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_username.CustomButton.TabIndex = 1;
            this.login_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_username.CustomButton.UseSelectable = true;
            this.login_username.CustomButton.Visible = false;
            this.login_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.login_username.Lines = new string[0];
            this.login_username.Location = new System.Drawing.Point(35, 10);
            this.login_username.MaxLength = 32767;
            this.login_username.Name = "login_username";
            this.login_username.PasswordChar = '\0';
            this.login_username.PromptText = "Username";
            this.login_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_username.SelectedText = "";
            this.login_username.SelectionLength = 0;
            this.login_username.SelectionStart = 0;
            this.login_username.ShortcutsEnabled = true;
            this.login_username.Size = new System.Drawing.Size(164, 23);
            this.login_username.TabIndex = 1;
            this.login_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_username.UseCustomBackColor = true;
            this.login_username.UseCustomForeColor = true;
            this.login_username.UseSelectable = true;
            this.login_username.WaterMark = "Username";
            this.login_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // login_password
            // 
            this.login_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.login_password.CustomButton.Image = null;
            this.login_password.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.login_password.CustomButton.Name = "";
            this.login_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_password.CustomButton.TabIndex = 1;
            this.login_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_password.CustomButton.UseSelectable = true;
            this.login_password.CustomButton.Visible = false;
            this.login_password.Lines = new string[0];
            this.login_password.Location = new System.Drawing.Point(35, 53);
            this.login_password.MaxLength = 32767;
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '●';
            this.login_password.PromptText = "Password";
            this.login_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_password.SelectedText = "";
            this.login_password.SelectionLength = 0;
            this.login_password.SelectionStart = 0;
            this.login_password.ShortcutsEnabled = true;
            this.login_password.Size = new System.Drawing.Size(164, 23);
            this.login_password.TabIndex = 2;
            this.login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_password.UseCustomBackColor = true;
            this.login_password.UseCustomForeColor = true;
            this.login_password.UseSelectable = true;
            this.login_password.UseSystemPasswordChar = true;
            this.login_password.WaterMark = "Password";
            this.login_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // register_container
            // 
            register_container.ColumnCount = 2;
            register_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            register_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            register_container.Controls.Add(this.register_button, 0, 0);
            register_container.Controls.Add(register_label, 0, 0);
            register_container.Location = new System.Drawing.Point(3, 248);
            register_container.Name = "register_container";
            register_container.RowCount = 1;
            register_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            register_container.Size = new System.Drawing.Size(234, 58);
            register_container.TabIndex = 6;
            // 
            // register_button
            // 
            this.register_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_button.Location = new System.Drawing.Point(154, 17);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(65, 23);
            this.register_button.TabIndex = 3;
            this.register_button.Text = "Register";
            this.register_button.UseCustomBackColor = true;
            this.register_button.UseCustomForeColor = true;
            this.register_button.UseSelectable = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // register_label
            // 
            register_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            register_label.AutoSize = true;
            register_label.FontSize = MetroFramework.MetroLabelSize.Small;
            register_label.Location = new System.Drawing.Point(9, 21);
            register_label.Name = "register_label";
            register_label.Size = new System.Drawing.Size(122, 15);
            register_label.TabIndex = 6;
            register_label.Text = "Don\'t have an account?";
            register_label.UseCustomBackColor = true;
            register_label.UseCustomForeColor = true;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 340);
            this.Controls.Add(login_container);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 340);
            this.MinimumSize = new System.Drawing.Size(240, 340);
            this.Name = "LoginScreen";
            this.Opacity = 0.8D;
            this.Resizable = false;
            this.ShowIcon = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            login_container.ResumeLayout(false);
            login_container.PerformLayout();
            textfield_container.ResumeLayout(false);
            register_container.ResumeLayout(false);
            register_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton login_button;
        private MetroFramework.Controls.MetroTextBox login_username;
        private MetroFramework.Controls.MetroTextBox login_password;
        private MetroFramework.Controls.MetroButton register_button;
    }
}