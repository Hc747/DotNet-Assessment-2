﻿using System.Windows.Forms;

namespace Assessment2.Solution.MVCO.View
{
    partial class UserListScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TableLayoutPanel info_container;
            System.Windows.Forms.TableLayoutPanel container;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.info_label = new MetroFramework.Controls.MetroLabel();
            this.textfield_container = new System.Windows.Forms.TableLayoutPanel();
            this.administration_button = new MetroFramework.Controls.MetroButton();
            this.rating_button = new MetroFramework.Controls.MetroButton();
            this.data_grid = new MetroFramework.Controls.MetroGrid();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select_column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            info_container = new System.Windows.Forms.TableLayoutPanel();
            container = new System.Windows.Forms.TableLayoutPanel();
            info_container.SuspendLayout();
            this.textfield_container.SuspendLayout();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // info_container
            // 
            info_container.ColumnCount = 1;
            info_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            info_container.Controls.Add(this.info_label, 0, 0);
            info_container.Controls.Add(this.textfield_container, 0, 1);
            info_container.Location = new System.Drawing.Point(1, 31);
            info_container.Name = "info_container";
            info_container.RowCount = 2;
            info_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            info_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            info_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            info_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            info_container.Size = new System.Drawing.Size(240, 303);
            info_container.TabIndex = 5;
            // 
            // info_label
            // 
            this.info_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info_label.AutoSize = true;
            this.info_label.FontSize = MetroFramework.MetroLabelSize.Small;
            this.info_label.Location = new System.Drawing.Point(73, 53);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(93, 15);
            this.info_label.TabIndex = 5;
            this.info_label.Text = "Signed in as: XXX";
            this.info_label.UseCustomBackColor = true;
            this.info_label.UseCustomForeColor = true;
            // 
            // textfield_container
            // 
            this.textfield_container.ColumnCount = 1;
            this.textfield_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.textfield_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.textfield_container.Controls.Add(this.administration_button, 0, 1);
            this.textfield_container.Controls.Add(this.rating_button, 0, 0);
            this.textfield_container.Location = new System.Drawing.Point(3, 124);
            this.textfield_container.Name = "textfield_container";
            this.textfield_container.RowCount = 2;
            this.textfield_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textfield_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textfield_container.Size = new System.Drawing.Size(234, 86);
            this.textfield_container.TabIndex = 1;
            // 
            // administration_button
            // 
            this.administration_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.administration_button.Location = new System.Drawing.Point(37, 53);
            this.administration_button.Name = "administration_button";
            this.administration_button.Size = new System.Drawing.Size(160, 23);
            this.administration_button.TabIndex = 3;
            this.administration_button.Text = "Make User(s) Admin";
            this.administration_button.UseCustomBackColor = true;
            this.administration_button.UseCustomForeColor = true;
            this.administration_button.UseSelectable = true;
            this.administration_button.Click += new System.EventHandler(this.administration_button_Click);
            // 
            // rating_button
            // 
            this.rating_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rating_button.Location = new System.Drawing.Point(37, 10);
            this.rating_button.Name = "rating_button";
            this.rating_button.Size = new System.Drawing.Size(160, 23);
            this.rating_button.TabIndex = 2;
            this.rating_button.Text = "Provide Rating to User(s)";
            this.rating_button.UseCustomBackColor = true;
            this.rating_button.UseCustomForeColor = true;
            this.rating_button.UseSelectable = true;
            this.rating_button.Click += new System.EventHandler(this.rating_button_Click);
            // 
            // container
            // 
            container.ColumnCount = 2;
            container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            container.Controls.Add(this.data_grid, 1, 0);
            container.Location = new System.Drawing.Point(1, 31);
            container.Name = "container";
            container.RowCount = 1;
            container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            container.Size = new System.Drawing.Size(718, 309);
            container.TabIndex = 6;
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.AllowUserToResizeColumns = false;
            this.data_grid.AllowUserToResizeRows = false;
            this.data_grid.AutoGenerateColumns = false;
            this.data_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.infoDataGridViewTextBoxColumn,
            this.averageRatingDataGridViewTextBoxColumn,
            this.ratingsCountDataGridViewTextBoxColumn,
            this.select_column});
            this.data_grid.DataSource = this.userModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_grid.EnableHeadersVisualStyles = false;
            this.data_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.data_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.data_grid.Location = new System.Drawing.Point(242, 3);
            this.data_grid.Name = "data_grid";
            this.data_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid.Size = new System.Drawing.Size(473, 303);
            this.data_grid.TabIndex = 0;
            this.data_grid.UseCustomBackColor = true;
            this.data_grid.UseCustomForeColor = true;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            // 
            // averageRatingDataGridViewTextBoxColumn
            // 
            this.averageRatingDataGridViewTextBoxColumn.DataPropertyName = "AverageRating";
            this.averageRatingDataGridViewTextBoxColumn.HeaderText = "AverageRating";
            this.averageRatingDataGridViewTextBoxColumn.Name = "averageRatingDataGridViewTextBoxColumn";
            // 
            // ratingsCountDataGridViewTextBoxColumn
            // 
            this.ratingsCountDataGridViewTextBoxColumn.DataPropertyName = "RatingsCount";
            this.ratingsCountDataGridViewTextBoxColumn.HeaderText = "RatingsCount";
            this.ratingsCountDataGridViewTextBoxColumn.Name = "ratingsCountDataGridViewTextBoxColumn";
            // 
            // select_column
            // 
            this.select_column.FalseValue = false;
            this.select_column.HeaderText = "Selected";
            this.select_column.Name = "select_column";
            this.select_column.TrueValue = true;
            // 
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(Assessment2.Solution.MVCO.Model.UserModel);
            // 
            // UserListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 340);
            this.Controls.Add(info_container);
            this.Controls.Add(container);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 340);
            this.MinimumSize = new System.Drawing.Size(720, 340);
            this.Name = "UserListScreen";
            this.Opacity = 0.8D;
            this.Resizable = false;
            this.ShowIcon = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.UserListScreen_Load);
            info_container.ResumeLayout(false);
            info_container.PerformLayout();
            this.textfield_container.ResumeLayout(false);
            container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton rating_button;
        private MetroFramework.Controls.MetroButton administration_button;
        private System.Windows.Forms.TableLayoutPanel textfield_container;
        private MetroFramework.Controls.MetroGrid data_grid;
        private MetroFramework.Controls.MetroLabel info_label;
        private System.Windows.Forms.BindingSource userModelBindingSource;
        private DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn averageRatingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ratingsCountDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn select_column;
    }
}