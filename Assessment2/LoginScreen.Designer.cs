using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.Label or_label;
            System.Windows.Forms.Label register_username_label;
            System.Windows.Forms.Label register_password_label;
            System.Windows.Forms.Label register_surname_label;
            System.Windows.Forms.Label register_first_name_label;
            System.Windows.Forms.Label register_birthday_label;
            this.component_container = new System.Windows.Forms.TableLayoutPanel();
            this.login_label = new System.Windows.Forms.Label();
            this.textfield_container = new System.Windows.Forms.TableLayoutPanel();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.new_user_button = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.register_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.register_surname = new System.Windows.Forms.TextBox();
            this.register_first_name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.register_username = new System.Windows.Forms.TextBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.register_birthday = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            or_label = new System.Windows.Forms.Label();
            register_username_label = new System.Windows.Forms.Label();
            register_password_label = new System.Windows.Forms.Label();
            register_surname_label = new System.Windows.Forms.Label();
            register_first_name_label = new System.Windows.Forms.Label();
            register_birthday_label = new System.Windows.Forms.Label();
            this.component_container.SuspendLayout();
            this.textfield_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // or_label
            // 
            or_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            or_label.AutoSize = true;
            or_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            or_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            or_label.Location = new System.Drawing.Point(32, 139);
            or_label.Margin = new System.Windows.Forms.Padding(0);
            or_label.Name = "or_label";
            or_label.Size = new System.Drawing.Size(26, 22);
            or_label.TabIndex = 5;
            or_label.Text = "or";
            // 
            // register_username_label
            // 
            register_username_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            register_username_label.AutoSize = true;
            register_username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            register_username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            register_username_label.Location = new System.Drawing.Point(0, 0);
            register_username_label.Margin = new System.Windows.Forms.Padding(0);
            register_username_label.Name = "register_username_label";
            register_username_label.Size = new System.Drawing.Size(95, 20);
            register_username_label.TabIndex = 5;
            register_username_label.Text = "Username";
            register_username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register_password_label
            // 
            register_password_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            register_password_label.AutoSize = true;
            register_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            register_password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            register_password_label.Location = new System.Drawing.Point(95, 0);
            register_password_label.Margin = new System.Windows.Forms.Padding(0);
            register_password_label.Name = "register_password_label";
            register_password_label.Size = new System.Drawing.Size(96, 20);
            register_password_label.TabIndex = 6;
            register_password_label.Text = "Password";
            register_password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register_surname_label
            // 
            register_surname_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            register_surname_label.AutoSize = true;
            register_surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            register_surname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            register_surname_label.Location = new System.Drawing.Point(95, 0);
            register_surname_label.Margin = new System.Windows.Forms.Padding(0);
            register_surname_label.Name = "register_surname_label";
            register_surname_label.Size = new System.Drawing.Size(96, 20);
            register_surname_label.TabIndex = 6;
            register_surname_label.Text = "Surname";
            register_surname_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register_first_name_label
            // 
            register_first_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            register_first_name_label.AutoSize = true;
            register_first_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            register_first_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            register_first_name_label.Location = new System.Drawing.Point(0, 0);
            register_first_name_label.Margin = new System.Windows.Forms.Padding(0);
            register_first_name_label.Name = "register_first_name_label";
            register_first_name_label.Size = new System.Drawing.Size(95, 20);
            register_first_name_label.TabIndex = 5;
            register_first_name_label.Text = "Forename";
            register_first_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register_birthday_label
            // 
            register_birthday_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            register_birthday_label.AutoSize = true;
            register_birthday_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            register_birthday_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            register_birthday_label.Location = new System.Drawing.Point(0, 0);
            register_birthday_label.Margin = new System.Windows.Forms.Padding(0);
            register_birthday_label.Name = "register_birthday_label";
            register_birthday_label.Size = new System.Drawing.Size(183, 17);
            register_birthday_label.TabIndex = 6;
            register_birthday_label.Text = "Birthday";
            register_birthday_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // component_container
            // 
            this.component_container.ColumnCount = 1;
            this.component_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.component_container.Controls.Add(this.login_label, 0, 0);
            this.component_container.Controls.Add(this.textfield_container, 0, 1);
            this.component_container.Controls.Add(this.login_button, 0, 3);
            this.component_container.Location = new System.Drawing.Point(0, 0);
            this.component_container.Margin = new System.Windows.Forms.Padding(0);
            this.component_container.Name = "component_container";
            this.component_container.RowCount = 4;
            this.component_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.component_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.component_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.component_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.component_container.Size = new System.Drawing.Size(194, 304);
            this.component_container.TabIndex = 0;
            // 
            // login_label
            // 
            this.login_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.login_label.Location = new System.Drawing.Point(24, 14);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(145, 17);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Login to your account";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textfield_container
            // 
            this.textfield_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textfield_container.ColumnCount = 1;
            this.textfield_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.textfield_container.Controls.Add(this.login_username, 0, 0);
            this.textfield_container.Controls.Add(this.login_password, 0, 1);
            this.textfield_container.Location = new System.Drawing.Point(0, 45);
            this.textfield_container.Margin = new System.Windows.Forms.Padding(0);
            this.textfield_container.Name = "textfield_container";
            this.textfield_container.RowCount = 2;
            this.textfield_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textfield_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textfield_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.textfield_container.Size = new System.Drawing.Size(194, 114);
            this.textfield_container.TabIndex = 1;
            // 
            // login_username
            // 
            this.login_username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.login_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.login_username.Location = new System.Drawing.Point(47, 40);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(100, 14);
            this.login_username.TabIndex = 2;
            this.login_username.TextChanged += new System.EventHandler(this.UsernameAndPassword_TextChanged);
            // 
            // login_password
            // 
            this.login_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.login_password.Location = new System.Drawing.Point(47, 60);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(100, 14);
            this.login_password.TabIndex = 3;
            this.login_password.UseSystemPasswordChar = true;
            this.login_password.TextChanged += new System.EventHandler(this.UsernameAndPassword_TextChanged);
            // 
            // login_button
            // 
            this.login_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_button.Location = new System.Drawing.Point(59, 277);
            this.login_button.Margin = new System.Windows.Forms.Padding(0);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // new_user_button
            // 
            this.new_user_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_user_button.Location = new System.Drawing.Point(57, 68);
            this.new_user_button.Margin = new System.Windows.Forms.Padding(0);
            this.new_user_button.Name = "new_user_button";
            this.new_user_button.Size = new System.Drawing.Size(75, 23);
            this.new_user_button.TabIndex = 6;
            this.new_user_button.Text = "New User";
            this.new_user_button.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.ImageLocation = "C:\\Users\\Admin\\Desktop\\Assessment2\\Assessment2\\Assets\\uts_logo.png";
            this.logo.Location = new System.Drawing.Point(0, 226);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(91, 48);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.component_container, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, -3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 307);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.register_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(291, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(195, 301);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // register_label
            // 
            this.register_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.register_label.Location = new System.Drawing.Point(30, 14);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(134, 17);
            this.register_label.TabIndex = 0;
            this.register_label.Text = "Register a new user";
            this.register_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(195, 112);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.register_surname, 1, 1);
            this.tableLayoutPanel6.Controls.Add(register_surname_label, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.register_first_name, 0, 1);
            this.tableLayoutPanel6.Controls.Add(register_first_name_label, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 59);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(191, 50);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // register_surname
            // 
            this.register_surname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.register_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.register_surname.Location = new System.Drawing.Point(98, 24);
            this.register_surname.Name = "register_surname";
            this.register_surname.Size = new System.Drawing.Size(90, 21);
            this.register_surname.TabIndex = 7;
            // 
            // register_first_name
            // 
            this.register_first_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_first_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.register_first_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_first_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.register_first_name.Location = new System.Drawing.Point(3, 24);
            this.register_first_name.Name = "register_first_name";
            this.register_first_name.Size = new System.Drawing.Size(89, 21);
            this.register_first_name.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(register_password_label, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.register_username, 0, 1);
            this.tableLayoutPanel4.Controls.Add(register_username_label, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.register_password, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(191, 52);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // register_username
            // 
            this.register_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.register_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.register_username.Location = new System.Drawing.Point(3, 25);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(89, 21);
            this.register_username.TabIndex = 4;
            // 
            // register_password
            // 
            this.register_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.register_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.register_password.Location = new System.Drawing.Point(98, 25);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(90, 21);
            this.register_password.TabIndex = 7;
            this.register_password.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.new_user_button, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 160);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(189, 106);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.register_birthday, 0, 1);
            this.tableLayoutPanel8.Controls.Add(register_birthday_label, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(183, 44);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // register_birthday
            // 
            this.register_birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_birthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.register_birthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.register_birthday.Location = new System.Drawing.Point(41, 20);
            this.register_birthday.Mask = "00/00/0000";
            this.register_birthday.Name = "register_birthday";
            this.register_birthday.PromptChar = 'X';
            this.register_birthday.Size = new System.Drawing.Size(100, 21);
            this.register_birthday.TabIndex = 7;
            this.register_birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(or_label, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.logo, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(197, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(91, 301);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(504, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 340);
            this.MinimumSize = new System.Drawing.Size(520, 340);
            this.Name = "LoginScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepSys";
            this.component_container.ResumeLayout(false);
            this.component_container.PerformLayout();
            this.textfield_container.ResumeLayout(false);
            this.textfield_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel component_container;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TableLayoutPanel textfield_container;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button new_user_button;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label register_label;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox register_username;
        private TextBox register_password;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox register_surname;
        private TextBox register_first_name;
        private MaskedTextBox register_birthday;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
    }
}

