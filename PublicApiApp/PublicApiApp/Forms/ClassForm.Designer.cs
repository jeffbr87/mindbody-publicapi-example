using System;

namespace PublicApiApp.Forms
{
    partial class ClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ClassListControl = new System.Windows.Forms.ListView();
            this.ClassIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassStartHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassEndHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassCapacityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddClientToClassButton = new System.Windows.Forms.Button();
            this.ClientServicesListControl = new System.Windows.Forms.ComboBox();
            this.dateFilterControl = new System.Windows.Forms.DateTimePicker();
            this.textFilterControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classes";
            // 
            // ClassListControl
            // 
            this.ClassListControl.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ClassListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassListControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassIdHeader,
            this.ClassNameHeader,
            this.ClassStartHeader,
            this.ClassEndHeader,
            this.ClassCapacityHeader});
            this.ClassListControl.FullRowSelect = true;
            this.ClassListControl.GridLines = true;
            this.ClassListControl.Location = new System.Drawing.Point(9, 77);
            this.ClassListControl.Margin = new System.Windows.Forms.Padding(2);
            this.ClassListControl.MultiSelect = false;
            this.ClassListControl.Name = "ClassListControl";
            this.ClassListControl.OwnerDraw = true;
            this.ClassListControl.ShowGroups = false;
            this.ClassListControl.Size = new System.Drawing.Size(698, 371);
            this.ClassListControl.TabIndex = 2;
            this.ClassListControl.UseCompatibleStateImageBehavior = false;
            this.ClassListControl.View = System.Windows.Forms.View.Details;
            this.ClassListControl.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ClassListControl_DrawColumnHeader);
            this.ClassListControl.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ClassListControl_DrawItem);
            this.ClassListControl.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ClassListControl_DrawSubItem);
            this.ClassListControl.Resize += new System.EventHandler(this.ClassListControl_Resize);
            // 
            // ClassIdHeader
            // 
            this.ClassIdHeader.Text = "ID";
            this.ClassIdHeader.Width = 100;
            // 
            // ClassNameHeader
            // 
            this.ClassNameHeader.Text = "Name";
            this.ClassNameHeader.Width = 200;
            // 
            // ClassStartHeader
            // 
            this.ClassStartHeader.Text = "Start";
            this.ClassStartHeader.Width = 150;
            // 
            // ClassEndHeader
            // 
            this.ClassEndHeader.Text = "End";
            this.ClassEndHeader.Width = 150;
            // 
            // ClassCapacityHeader
            // 
            this.ClassCapacityHeader.Text = "Capacity";
            // 
            // AddClientToClassButton
            // 
            this.AddClientToClassButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClientToClassButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddClientToClassButton.Location = new System.Drawing.Point(537, 462);
            this.AddClientToClassButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.AddClientToClassButton.Name = "AddClientToClassButton";
            this.AddClientToClassButton.Size = new System.Drawing.Size(170, 40);
            this.AddClientToClassButton.TabIndex = 3;
            this.AddClientToClassButton.Text = "Add Client to Class";
            this.AddClientToClassButton.UseVisualStyleBackColor = false;
            this.AddClientToClassButton.Click += new System.EventHandler(this.AddClientToClassButton_click);
            // 
            // ClientServicesListControl
            // 
            this.ClientServicesListControl.FormattingEnabled = true;
            this.ClientServicesListControl.Location = new System.Drawing.Point(9, 43);
            this.ClientServicesListControl.Name = "ClientServicesListControl";
            this.ClientServicesListControl.Size = new System.Drawing.Size(367, 21);
            this.ClientServicesListControl.TabIndex = 4;
            // 
            // dateFilterControl
            // 
            this.dateFilterControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFilterControl.Location = new System.Drawing.Point(468, 17);
            this.dateFilterControl.MinDate = new System.DateTime(2017, 7, 7, 0, 0, 0, 0);
            this.dateFilterControl.Name = "dateFilterControl";
            this.dateFilterControl.Size = new System.Drawing.Size(239, 20);
            this.dateFilterControl.TabIndex = 5;
            this.dateFilterControl.Visible = false;
            this.dateFilterControl.ValueChanged += new System.EventHandler(this.dateFilterBox_ValueChanged);
            // 
            // textFilterControl
            // 
            this.textFilterControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilterControl.Location = new System.Drawing.Point(468, 44);
            this.textFilterControl.Name = "textFilterControl";
            this.textFilterControl.Size = new System.Drawing.Size(239, 20);
            this.textFilterControl.TabIndex = 6;
            this.textFilterControl.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter by name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client\'s Service Pricing Options:";
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFilterControl);
            this.Controls.Add(this.dateFilterControl);
            this.Controls.Add(this.ClientServicesListControl);
            this.Controls.Add(this.AddClientToClassButton);
            this.Controls.Add(this.ClassListControl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(731, 549);
            this.Name = "ClassForm";
            this.Text = "Add Client to Class";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ClassListControl;
        private System.Windows.Forms.Button AddClientToClassButton;
        private System.Windows.Forms.ComboBox ClientServicesListControl;
        private System.Windows.Forms.DateTimePicker dateFilterControl;
        private System.Windows.Forms.TextBox textFilterControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader ClassIdHeader;
        private System.Windows.Forms.ColumnHeader ClassNameHeader;
        private System.Windows.Forms.ColumnHeader ClassStartHeader;
        private System.Windows.Forms.ColumnHeader ClassEndHeader;
        private System.Windows.Forms.ColumnHeader ClassCapacityHeader;
    }
}