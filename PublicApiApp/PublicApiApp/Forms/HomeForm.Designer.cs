namespace PublicApiApp
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.addClient = new System.Windows.Forms.Button();
            this.studioName = new System.Windows.Forms.Label();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.addClientToClass = new System.Windows.Forms.Button();
            this.updateClient = new System.Windows.Forms.Button();
            this.getClientSchedule = new System.Windows.Forms.Button();
            this.withSelectedClientLabel = new System.Windows.Forms.Label();
            this.getClientsAndClasses = new System.Windows.Forms.Button();
            this.enso = new System.Windows.Forms.PictureBox();
            this.todaysSales = new System.Windows.Forms.Label();
            this.salesAmount = new System.Windows.Forms.Label();
            this.getClientsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientGrid = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.enso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(457, 110);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(196, 23);
            this.addClient.TabIndex = 0;
            this.addClient.Text = "Add a Client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // studioName
            // 
            this.studioName.AutoSize = true;
            this.studioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studioName.Location = new System.Drawing.Point(12, 12);
            this.studioName.Name = "studioName";
            this.studioName.Size = new System.Drawing.Size(167, 25);
            this.studioName.TabIndex = 2;
            this.studioName.Text = "API Sandbox Site";
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Location = new System.Drawing.Point(13, 53);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(38, 13);
            this.clientsLabel.TabIndex = 3;
            this.clientsLabel.Text = "Clients";
            // 
            // addClientToClass
            // 
            this.addClientToClass.Location = new System.Drawing.Point(12, 348);
            this.addClientToClass.Name = "addClientToClass";
            this.addClientToClass.Size = new System.Drawing.Size(196, 23);
            this.addClientToClass.TabIndex = 7;
            this.addClientToClass.Text = "Book a Class";
            this.addClientToClass.UseVisualStyleBackColor = true;
            // 
            // updateClient
            // 
            this.updateClient.Location = new System.Drawing.Point(255, 348);
            this.updateClient.Name = "updateClient";
            this.updateClient.Size = new System.Drawing.Size(196, 23);
            this.updateClient.TabIndex = 9;
            this.updateClient.Text = "Update Client";
            this.updateClient.UseVisualStyleBackColor = true;
            // 
            // getClientSchedule
            // 
            this.getClientSchedule.Location = new System.Drawing.Point(12, 381);
            this.getClientSchedule.Name = "getClientSchedule";
            this.getClientSchedule.Size = new System.Drawing.Size(196, 23);
            this.getClientSchedule.TabIndex = 10;
            this.getClientSchedule.Text = "View Schedule";
            this.getClientSchedule.UseVisualStyleBackColor = true;
            // 
            // withSelectedClientLabel
            // 
            this.withSelectedClientLabel.AutoSize = true;
            this.withSelectedClientLabel.Location = new System.Drawing.Point(12, 332);
            this.withSelectedClientLabel.Name = "withSelectedClientLabel";
            this.withSelectedClientLabel.Size = new System.Drawing.Size(103, 13);
            this.withSelectedClientLabel.TabIndex = 12;
            this.withSelectedClientLabel.Text = "With selected client:";
            // 
            // getClientsAndClasses
            // 
            this.getClientsAndClasses.Location = new System.Drawing.Point(457, 72);
            this.getClientsAndClasses.Name = "getClientsAndClasses";
            this.getClientsAndClasses.Size = new System.Drawing.Size(196, 23);
            this.getClientsAndClasses.TabIndex = 0;
            this.getClientsAndClasses.Text = "Update Client List";
            this.getClientsAndClasses.UseVisualStyleBackColor = true;
            this.getClientsAndClasses.Click += new System.EventHandler(this.getClientsAndClasses_Click);
            // 
            // enso
            // 
            this.enso.Image = ((System.Drawing.Image)(resources.GetObject("enso.Image")));
            this.enso.Location = new System.Drawing.Point(472, 170);
            this.enso.Name = "enso";
            this.enso.Size = new System.Drawing.Size(160, 175);
            this.enso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enso.TabIndex = 16;
            this.enso.TabStop = false;
            // 
            // todaysSales
            // 
            this.todaysSales.AutoSize = true;
            this.todaysSales.Location = new System.Drawing.Point(469, 24);
            this.todaysSales.Name = "todaysSales";
            this.todaysSales.Size = new System.Drawing.Size(76, 13);
            this.todaysSales.TabIndex = 17;
            this.todaysSales.Text = "Today\'s Sales:";
            // 
            // salesAmount
            // 
            this.salesAmount.AutoSize = true;
            this.salesAmount.Location = new System.Drawing.Point(551, 24);
            this.salesAmount.Name = "salesAmount";
            this.salesAmount.Size = new System.Drawing.Size(19, 13);
            this.salesAmount.TabIndex = 18;
            this.salesAmount.Text = "$0";
            // 
            // getClientsResultBindingSource
            // 
            this.getClientsResultBindingSource.DataSource = typeof(PublicApiApp.ClientService.GetClientsResult);
            // 
            // clientGrid
            // 
            this.clientGrid.AllowUserToAddRows = false;
            this.clientGrid.AllowUserToDeleteRows = false;
            this.clientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Email,
            this.ClientId});
            this.clientGrid.Location = new System.Drawing.Point(12, 72);
            this.clientGrid.Name = "clientGrid";
            this.clientGrid.ReadOnly = true;
            this.clientGrid.Size = new System.Drawing.Size(439, 240);
            this.clientGrid.TabIndex = 19;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "Client ID";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 421);
            this.Controls.Add(this.clientGrid);
            this.Controls.Add(this.salesAmount);
            this.Controls.Add(this.todaysSales);
            this.Controls.Add(this.enso);
            this.Controls.Add(this.getClientsAndClasses);
            this.Controls.Add(this.withSelectedClientLabel);
            this.Controls.Add(this.getClientSchedule);
            this.Controls.Add(this.updateClient);
            this.Controls.Add(this.addClientToClass);
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.studioName);
            this.Controls.Add(this.addClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HomeForm";
            this.Text = "MINDBODY Booker";
            ((System.ComponentModel.ISupportInitialize)(this.enso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Label studioName;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.Button addClientToClass;
        private System.Windows.Forms.Button updateClient;
        private System.Windows.Forms.Button getClientSchedule;
        private System.Windows.Forms.Label withSelectedClientLabel;
        private System.Windows.Forms.Button getClientsAndClasses;
        private System.Windows.Forms.PictureBox enso;
        private System.Windows.Forms.Label todaysSales;
        private System.Windows.Forms.Label salesAmount;
        private System.Windows.Forms.BindingSource getClientsResultBindingSource;
        private System.Windows.Forms.DataGridView clientGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
    }
}

