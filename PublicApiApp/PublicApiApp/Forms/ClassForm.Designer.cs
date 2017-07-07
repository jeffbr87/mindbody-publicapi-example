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
            this.AddClientToClassButton = new System.Windows.Forms.Button();
            this.ClientServicesListControl = new System.Windows.Forms.ComboBox();
            this.dateFilterControl = new System.Windows.Forms.DateTimePicker();
            this.textFilterControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClassListControl
            // 
            this.ClassListControl.Location = new System.Drawing.Point(6, 139);
            this.ClassListControl.Margin = new System.Windows.Forms.Padding(2);
            this.ClassListControl.MultiSelect = false;
            this.ClassListControl.Name = "ClassListControl";
            this.ClassListControl.Size = new System.Drawing.Size(698, 333);
            this.ClassListControl.TabIndex = 2;
            this.ClassListControl.UseCompatibleStateImageBehavior = false;
            this.ClassListControl.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // AddClientToClassButton
            // 
            this.AddClientToClassButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClientToClassButton.Location = new System.Drawing.Point(534, 486);
            this.AddClientToClassButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.AddClientToClassButton.Name = "AddClientToClassButton";
            this.AddClientToClassButton.Size = new System.Drawing.Size(170, 40);
            this.AddClientToClassButton.TabIndex = 3;
            this.AddClientToClassButton.Text = "Add Client to Class";
            this.AddClientToClassButton.UseVisualStyleBackColor = true;
            this.AddClientToClassButton.Click += new System.EventHandler(this.AddClientToClassButton_click);
            // 
            // ClientServicesListControl
            // 
            this.ClientServicesListControl.FormattingEnabled = true;
            this.ClientServicesListControl.Location = new System.Drawing.Point(6, 66);
            this.ClientServicesListControl.Name = "ClientServicesListControl";
            this.ClientServicesListControl.Size = new System.Drawing.Size(258, 21);
            this.ClientServicesListControl.TabIndex = 4;
            // 
            // dateFilterControl
            // 
            this.dateFilterControl.Location = new System.Drawing.Point(319, 67);
            this.dateFilterControl.Name = "dateFilterControl";
            this.dateFilterControl.Size = new System.Drawing.Size(200, 20);
            this.dateFilterControl.TabIndex = 5;
            this.dateFilterControl.ValueChanged += new System.EventHandler(this.dateFilterBox_ValueChanged);
            // 
            // textFilterControl
            // 
            this.textFilterControl.Location = new System.Drawing.Point(63, 108);
            this.textFilterControl.Name = "textFilterControl";
            this.textFilterControl.Size = new System.Drawing.Size(641, 20);
            this.textFilterControl.TabIndex = 6;
            this.textFilterControl.Text = "Filter by text";
            this.textFilterControl.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Client Services";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.Location = new System.Drawing.Point(5, 15);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(95, 20);
            this.clientNameLabel.TabIndex = 8;
            this.clientNameLabel.Text = "Client Name";
            this.clientNameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 531);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFilterControl);
            this.Controls.Add(this.dateFilterControl);
            this.Controls.Add(this.ClientServicesListControl);
            this.Controls.Add(this.AddClientToClassButton);
            this.Controls.Add(this.ClassListControl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClassForm";
            this.Text = "Add Client to Class";
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
        private System.Windows.Forms.Label clientNameLabel;
    }
}