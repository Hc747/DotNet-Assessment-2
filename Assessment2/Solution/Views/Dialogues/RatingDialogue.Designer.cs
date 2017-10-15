namespace Assessment2.Solution.Views.Dialogues
{
    partial class RatingDialogue
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
            MetroFramework.Controls.MetroLabel title_label;
            System.Windows.Forms.TableLayoutPanel register_container;
            MetroFramework.Controls.MetroRadioButton option_0;
            MetroFramework.Controls.MetroRadioButton option_1;
            MetroFramework.Controls.MetroRadioButton option_2;
            MetroFramework.Controls.MetroRadioButton option_3;
            MetroFramework.Controls.MetroRadioButton option_4;
            MetroFramework.Controls.MetroRadioButton option_5;
            this.submit_button = new MetroFramework.Controls.MetroButton();
            this.cancel_button = new MetroFramework.Controls.MetroButton();
            this.info_label = new MetroFramework.Controls.MetroLabel();
            this.button_container = new System.Windows.Forms.GroupBox();
            login_container = new System.Windows.Forms.TableLayoutPanel();
            title_label = new MetroFramework.Controls.MetroLabel();
            register_container = new System.Windows.Forms.TableLayoutPanel();
            option_0 = new MetroFramework.Controls.MetroRadioButton();
            option_1 = new MetroFramework.Controls.MetroRadioButton();
            option_2 = new MetroFramework.Controls.MetroRadioButton();
            option_3 = new MetroFramework.Controls.MetroRadioButton();
            option_4 = new MetroFramework.Controls.MetroRadioButton();
            option_5 = new MetroFramework.Controls.MetroRadioButton();
            login_container.SuspendLayout();
            register_container.SuspendLayout();
            this.button_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_container
            // 
            login_container.ColumnCount = 1;
            login_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            login_container.Controls.Add(title_label, 0, 0);
            login_container.Controls.Add(this.info_label, 0, 2);
            login_container.Controls.Add(register_container, 0, 3);
            login_container.Controls.Add(this.button_container, 0, 1);
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
            // title_label
            // 
            title_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            title_label.AutoSize = true;
            title_label.Location = new System.Drawing.Point(69, 21);
            title_label.Name = "title_label";
            title_label.Size = new System.Drawing.Size(102, 19);
            title_label.TabIndex = 5;
            title_label.Text = "Rating Dialogue";
            title_label.UseCustomBackColor = true;
            title_label.UseCustomForeColor = true;
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
            // info_label
            // 
            this.info_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info_label.AutoSize = true;
            this.info_label.FontSize = MetroFramework.MetroLabelSize.Small;
            this.info_label.Location = new System.Drawing.Point(69, 191);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(101, 15);
            this.info_label.TabIndex = 6;
            this.info_label.Text = "INFO_LABEL_TEXT";
            this.info_label.UseCustomBackColor = true;
            this.info_label.UseCustomForeColor = true;
            // 
            // button_container
            // 
            this.button_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_container.Controls.Add(option_5);
            this.button_container.Controls.Add(option_4);
            this.button_container.Controls.Add(option_3);
            this.button_container.Controls.Add(option_2);
            this.button_container.Controls.Add(option_1);
            this.button_container.Controls.Add(option_0);
            this.button_container.Location = new System.Drawing.Point(3, 64);
            this.button_container.Name = "button_container";
            this.button_container.Size = new System.Drawing.Size(234, 86);
            this.button_container.TabIndex = 7;
            this.button_container.TabStop = false;
            // 
            // option_0
            // 
            option_0.AutoSize = true;
            option_0.Location = new System.Drawing.Point(13, 36);
            option_0.Name = "option_0";
            option_0.Size = new System.Drawing.Size(29, 15);
            option_0.TabIndex = 0;
            option_0.Text = "0";
            option_0.UseCustomBackColor = true;
            option_0.UseCustomForeColor = true;
            option_0.UseSelectable = true;
            // 
            // option_1
            // 
            option_1.AutoSize = true;
            option_1.Location = new System.Drawing.Point(52, 36);
            option_1.Name = "option_1";
            option_1.Size = new System.Drawing.Size(29, 15);
            option_1.TabIndex = 1;
            option_1.Text = "1";
            option_1.UseCustomBackColor = true;
            option_1.UseCustomForeColor = true;
            option_1.UseSelectable = true;
            // 
            // option_2
            // 
            option_2.AutoSize = true;
            option_2.Location = new System.Drawing.Point(87, 36);
            option_2.Name = "option_2";
            option_2.Size = new System.Drawing.Size(29, 15);
            option_2.TabIndex = 2;
            option_2.Text = "2";
            option_2.UseCustomBackColor = true;
            option_2.UseCustomForeColor = true;
            option_2.UseSelectable = true;
            // 
            // option_3
            // 
            option_3.AutoSize = true;
            option_3.Location = new System.Drawing.Point(122, 36);
            option_3.Name = "option_3";
            option_3.Size = new System.Drawing.Size(29, 15);
            option_3.TabIndex = 3;
            option_3.Text = "3";
            option_3.UseCustomBackColor = true;
            option_3.UseCustomForeColor = true;
            option_3.UseSelectable = true;
            // 
            // option_4
            // 
            option_4.AutoSize = true;
            option_4.Location = new System.Drawing.Point(157, 36);
            option_4.Name = "option_4";
            option_4.Size = new System.Drawing.Size(29, 15);
            option_4.TabIndex = 4;
            option_4.Text = "4";
            option_4.UseCustomBackColor = true;
            option_4.UseCustomForeColor = true;
            option_4.UseSelectable = true;
            // 
            // option_5
            // 
            option_5.AutoSize = true;
            option_5.Location = new System.Drawing.Point(192, 36);
            option_5.Name = "option_5";
            option_5.Size = new System.Drawing.Size(29, 15);
            option_5.TabIndex = 5;
            option_5.Text = "5";
            option_5.UseCustomBackColor = true;
            option_5.UseCustomForeColor = true;
            option_5.UseSelectable = true;
            // 
            // RatingDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 340);
            this.Controls.Add(login_container);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 340);
            this.MinimumSize = new System.Drawing.Size(240, 340);
            this.Name = "RatingDialogue";
            this.Opacity = 0.8D;
            this.Resizable = false;
            this.ShowIcon = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            login_container.ResumeLayout(false);
            login_container.PerformLayout();
            register_container.ResumeLayout(false);
            this.button_container.ResumeLayout(false);
            this.button_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton submit_button;
        private MetroFramework.Controls.MetroButton cancel_button;
        private System.Windows.Forms.GroupBox button_container;
        private MetroFramework.Controls.MetroLabel info_label;
    }
}