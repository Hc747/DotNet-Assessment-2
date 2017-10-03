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
            this.base_container = new System.Windows.Forms.Panel();
            this.component_container = new System.Windows.Forms.TableLayoutPanel();
            this.login_label = new System.Windows.Forms.Label();
            this.textfield_container = new System.Windows.Forms.TableLayoutPanel();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button_container = new System.Windows.Forms.TableLayoutPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.login_button = new System.Windows.Forms.Button();
            this.new_user_button = new System.Windows.Forms.Button();
            or_label = new System.Windows.Forms.Label();
            this.base_container.SuspendLayout();
            this.component_container.SuspendLayout();
            this.textfield_container.SuspendLayout();
            this.button_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // or_label
            // 
            or_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            or_label.AutoSize = true;
            or_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            or_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            or_label.Location = new System.Drawing.Point(102, 37);
            or_label.Margin = new System.Windows.Forms.Padding(0);
            or_label.Name = "or_label";
            or_label.Size = new System.Drawing.Size(20, 16);
            or_label.TabIndex = 3;
            or_label.Text = "or";
            or_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // base_container
            // 
            this.base_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.base_container.Controls.Add(this.component_container);
            this.base_container.Location = new System.Drawing.Point(0, -1);
            this.base_container.Name = "base_container";
            this.base_container.Size = new System.Drawing.Size(224, 303);
            this.base_container.TabIndex = 0;
            // 
            // component_container
            // 
            this.component_container.ColumnCount = 1;
            this.component_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.component_container.Controls.Add(this.login_label, 0, 0);
            this.component_container.Controls.Add(this.textfield_container, 0, 1);
            this.component_container.Controls.Add(this.button_container, 0, 2);
            this.component_container.Controls.Add(this.logo, 0, 3);
            this.component_container.Location = new System.Drawing.Point(0, 3);
            this.component_container.Margin = new System.Windows.Forms.Padding(0);
            this.component_container.Name = "component_container";
            this.component_container.RowCount = 4;
            this.component_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.component_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.component_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.component_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.component_container.Size = new System.Drawing.Size(224, 300);
            this.component_container.TabIndex = 0;
            // 
            // login_label
            // 
            this.login_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.login_label.Location = new System.Drawing.Point(45, 22);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(134, 16);
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
            this.textfield_container.Controls.Add(this.username, 0, 0);
            this.textfield_container.Controls.Add(this.password, 0, 1);
            this.textfield_container.Location = new System.Drawing.Point(0, 60);
            this.textfield_container.Margin = new System.Windows.Forms.Padding(0);
            this.textfield_container.Name = "textfield_container";
            this.textfield_container.RowCount = 2;
            this.textfield_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textfield_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textfield_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.textfield_container.Size = new System.Drawing.Size(224, 90);
            this.textfield_container.TabIndex = 1;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.username.Location = new System.Drawing.Point(62, 21);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 21);
            this.username.TabIndex = 2;
            this.username.Controls.Add(new System.Windows.Forms.Label() {
                Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black
            });
            this.username.TextChanged += new System.EventHandler(this.UsernameAndPassword_TextChanged);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.password.Location = new System.Drawing.Point(62, 48);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 21);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            this.password.Controls.Add(new System.Windows.Forms.Label() {
                Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black
            });
            this.password.TextChanged += new System.EventHandler(this.UsernameAndPassword_TextChanged);
            // 
            // button_container
            // 
            this.button_container.ColumnCount = 1;
            this.button_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.button_container.Controls.Add(or_label, 0, 1);
            this.button_container.Controls.Add(this.new_user_button, 0, 2);
            this.button_container.Controls.Add(this.login_button, 0, 0);
            this.button_container.Location = new System.Drawing.Point(0, 150);
            this.button_container.Margin = new System.Windows.Forms.Padding(0);
            this.button_container.Name = "button_container";
            this.button_container.RowCount = 3;
            this.button_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.button_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.button_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.button_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.button_container.Size = new System.Drawing.Size(224, 90);
            this.button_container.TabIndex = 3;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.ImageLocation = "C:\\Users\\Admin\\Desktop\\Assessment2\\Assessment2\\Assets\\uts_logo.png";
            this.logo.Location = new System.Drawing.Point(51, 240);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(122, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // login_button
            // 
            this.login_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.login_button.Location = new System.Drawing.Point(74, 13);
            this.login_button.Margin = new System.Windows.Forms.Padding(0);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // new_user_button
            // 
            this.new_user_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.new_user_button.Location = new System.Drawing.Point(74, 54);
            this.new_user_button.Margin = new System.Windows.Forms.Padding(0);
            this.new_user_button.Name = "new_user_button";
            this.new_user_button.Size = new System.Drawing.Size(75, 23);
            this.new_user_button.TabIndex = 6;
            this.new_user_button.Text = "New User";
            this.new_user_button.UseVisualStyleBackColor = true;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(224, 301);
            this.Controls.Add(this.base_container);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 340);
            this.MinimumSize = new System.Drawing.Size(240, 340);
            this.Name = "LoginScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepSys";
            this.base_container.ResumeLayout(false);
            this.component_container.ResumeLayout(false);
            this.component_container.PerformLayout();
            this.textfield_container.ResumeLayout(false);
            this.textfield_container.PerformLayout();
            this.button_container.ResumeLayout(false);
            this.button_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel base_container;
        private System.Windows.Forms.TableLayoutPanel component_container;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TableLayoutPanel textfield_container;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TableLayoutPanel button_container;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button new_user_button;
    }
}

