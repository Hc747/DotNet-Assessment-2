namespace Assessment2.Solution.Views.Dialogues
{
    partial class AdministrationDialogue
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
            System.Windows.Forms.TableLayoutPanel register_container;
            this.info_label = new MetroFramework.Controls.MetroLabel();
            this.submit_button = new MetroFramework.Controls.MetroButton();
            this.cancel_button = new MetroFramework.Controls.MetroButton();
            this.admin_values = new MetroFramework.Controls.MetroComboBox();
            login_container = new System.Windows.Forms.TableLayoutPanel();
            login_label = new MetroFramework.Controls.MetroLabel();
            register_container = new System.Windows.Forms.TableLayoutPanel();
            login_container.SuspendLayout();
            register_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_container
            // 
            login_container.ColumnCount = 1;
            login_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            login_container.Controls.Add(this.info_label, 0, 2);
            login_container.Controls.Add(login_label, 0, 0);
            login_container.Controls.Add(register_container, 0, 3);
            login_container.Controls.Add(this.admin_values, 0, 1);
            login_container.Location = new System.Drawing.Point(0, 31);
            login_container.Name = "login_container";
            login_container.RowCount = 4;
            login_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            login_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            login_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            login_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            login_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            login_container.Size = new System.Drawing.Size(240, 309);
            login_container.TabIndex = 5;
            // 
            // info_label
            // 
            this.info_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info_label.AutoSize = true;
            this.info_label.FontSize = MetroFramework.MetroLabelSize.Small;
            this.info_label.Location = new System.Drawing.Point(69, 191);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(101, 15);
            this.info_label.TabIndex = 7;
            this.info_label.Text = "INFO_LABEL_TEXT";
            this.info_label.UseCustomBackColor = true;
            this.info_label.UseCustomForeColor = true;
            // 
            // login_label
            // 
            login_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            login_label.AutoSize = true;
            login_label.Location = new System.Drawing.Point(45, 21);
            login_label.Name = "login_label";
            login_label.Size = new System.Drawing.Size(150, 19);
            login_label.TabIndex = 5;
            login_label.Text = "Administration Dialogue";
            login_label.UseCustomBackColor = true;
            login_label.UseCustomForeColor = true;
            // 
            // register_container
            // 
            register_container.ColumnCount = 2;
            register_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            register_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            register_container.Controls.Add(this.submit_button, 1, 0);
            register_container.Controls.Add(this.cancel_button, 0, 0);
            register_container.Location = new System.Drawing.Point(3, 248);
            register_container.Name = "register_container";
            register_container.RowCount = 1;
            register_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            register_container.Size = new System.Drawing.Size(234, 58);
            register_container.TabIndex = 6;
            // 
            // submit_button
            // 
            this.submit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit_button.Location = new System.Drawing.Point(138, 17);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 2;
            this.submit_button.Text = "Submit";
            this.submit_button.UseCustomBackColor = true;
            this.submit_button.UseCustomForeColor = true;
            this.submit_button.UseSelectable = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel_button.Location = new System.Drawing.Point(26, 17);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(65, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseCustomBackColor = true;
            this.cancel_button.UseCustomForeColor = true;
            this.cancel_button.UseSelectable = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // admin_values
            // 
            this.admin_values.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_values.BackColor = System.Drawing.SystemColors.Window;
            this.admin_values.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.admin_values.FormattingEnabled = true;
            this.admin_values.ItemHeight = 23;
            this.admin_values.Location = new System.Drawing.Point(59, 92);
            this.admin_values.Name = "admin_values";
            this.admin_values.Size = new System.Drawing.Size(121, 29);
            this.admin_values.TabIndex = 0;
            this.admin_values.UseCustomBackColor = true;
            this.admin_values.UseCustomForeColor = true;
            this.admin_values.UseSelectable = true;
            // 
            // AdministrationDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 340);
            this.Controls.Add(login_container);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 340);
            this.MinimumSize = new System.Drawing.Size(240, 340);
            this.Name = "AdministrationDialogue";
            this.Opacity = 0.8D;
            this.Resizable = false;
            this.ShowIcon = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            login_container.ResumeLayout(false);
            login_container.PerformLayout();
            register_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton submit_button;
        private MetroFramework.Controls.MetroButton cancel_button;
        private MetroFramework.Controls.MetroComboBox admin_values;
        private MetroFramework.Controls.MetroLabel info_label;
    }
}