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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.addClient = new System.Windows.Forms.Button();
            this.clientList = new System.Windows.Forms.ListView();
            this.studioName = new System.Windows.Forms.Label();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.classesLabel = new System.Windows.Forms.Label();
            this.classList = new System.Windows.Forms.ListView();
            this.addClientToClass = new System.Windows.Forms.Button();
            this.getSales = new System.Windows.Forms.Button();
            this.updateClient = new System.Windows.Forms.Button();
            this.getClientSchedule = new System.Windows.Forms.Button();
            this.withSelectedClientLabel = new System.Windows.Forms.Label();
            this.andSelectedClassLabel = new System.Windows.Forms.Label();
            this.getClientsAndClasses = new System.Windows.Forms.Button();
            this.getClientServices = new System.Windows.Forms.Button();
            this.enso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enso)).BeginInit();
            this.SuspendLayout();
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(457, 155);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(196, 23);
            this.addClient.TabIndex = 0;
            this.addClient.Text = "Add a Client";
            this.addClient.UseVisualStyleBackColor = true;
            // 
            // clientList
            // 
            this.clientList.Location = new System.Drawing.Point(12, 72);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(196, 253);
            this.clientList.TabIndex = 1;
            this.clientList.UseCompatibleStateImageBehavior = false;
            // 
            // studioName
            // 
            this.studioName.AutoSize = true;
            this.studioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studioName.Location = new System.Drawing.Point(12, 12);
            this.studioName.Name = "studioName";
            this.studioName.Size = new System.Drawing.Size(147, 25);
            this.studioName.TabIndex = 2;
            this.studioName.Text = "MyStudioName";
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
            // classesLabel
            // 
            this.classesLabel.AutoSize = true;
            this.classesLabel.Location = new System.Drawing.Point(238, 53);
            this.classesLabel.Name = "classesLabel";
            this.classesLabel.Size = new System.Drawing.Size(43, 13);
            this.classesLabel.TabIndex = 6;
            this.classesLabel.Text = "Classes";
            // 
            // classList
            // 
            this.classList.Location = new System.Drawing.Point(237, 72);
            this.classList.Name = "classList";
            this.classList.Size = new System.Drawing.Size(196, 253);
            this.classList.TabIndex = 5;
            this.classList.UseCompatibleStateImageBehavior = false;
            // 
            // addClientToClass
            // 
            this.addClientToClass.Location = new System.Drawing.Point(237, 352);
            this.addClientToClass.Name = "addClientToClass";
            this.addClientToClass.Size = new System.Drawing.Size(196, 23);
            this.addClientToClass.TabIndex = 7;
            this.addClientToClass.Text = "Add Client to Class";
            this.addClientToClass.UseVisualStyleBackColor = true;
            // 
            // getSales
            // 
            this.getSales.Location = new System.Drawing.Point(457, 184);
            this.getSales.Name = "getSales";
            this.getSales.Size = new System.Drawing.Size(196, 23);
            this.getSales.TabIndex = 8;
            this.getSales.Text = "Get Sales";
            this.getSales.UseVisualStyleBackColor = true;
            // 
            // updateClient
            // 
            this.updateClient.Location = new System.Drawing.Point(12, 352);
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
            this.getClientSchedule.Text = "Get Schedule";
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
            // andSelectedClassLabel
            // 
            this.andSelectedClassLabel.AutoSize = true;
            this.andSelectedClassLabel.Location = new System.Drawing.Point(234, 332);
            this.andSelectedClassLabel.Name = "andSelectedClassLabel";
            this.andSelectedClassLabel.Size = new System.Drawing.Size(99, 13);
            this.andSelectedClassLabel.TabIndex = 13;
            this.andSelectedClassLabel.Text = "And selected class:";
            // 
            // getClientsAndClasses
            // 
            this.getClientsAndClasses.Location = new System.Drawing.Point(457, 72);
            this.getClientsAndClasses.Name = "getClientsAndClasses";
            this.getClientsAndClasses.Size = new System.Drawing.Size(196, 23);
            this.getClientsAndClasses.TabIndex = 0;
            this.getClientsAndClasses.Text = "Get Clients && Classes";
            this.getClientsAndClasses.UseVisualStyleBackColor = true;
            this.getClientsAndClasses.Click += new System.EventHandler(this.getClientsAndClasses_Click);
            // 
            // getClientServices
            // 
            this.getClientServices.Location = new System.Drawing.Point(12, 410);
            this.getClientServices.Name = "getClientServices";
            this.getClientServices.Size = new System.Drawing.Size(196, 23);
            this.getClientServices.TabIndex = 15;
            this.getClientServices.Text = "Get Purchased Services";
            this.getClientServices.UseVisualStyleBackColor = true;
            // 
            // enso
            // 
            this.enso.Image = ((System.Drawing.Image)(resources.GetObject("enso.Image")));
            this.enso.Location = new System.Drawing.Point(472, 240);
            this.enso.Name = "enso";
            this.enso.Size = new System.Drawing.Size(160, 175);
            this.enso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enso.TabIndex = 16;
            this.enso.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 442);
            this.Controls.Add(this.enso);
            this.Controls.Add(this.getClientServices);
            this.Controls.Add(this.getClientsAndClasses);
            this.Controls.Add(this.andSelectedClassLabel);
            this.Controls.Add(this.withSelectedClientLabel);
            this.Controls.Add(this.getClientSchedule);
            this.Controls.Add(this.updateClient);
            this.Controls.Add(this.getSales);
            this.Controls.Add(this.addClientToClass);
            this.Controls.Add(this.classesLabel);
            this.Controls.Add(this.classList);
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.studioName);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.addClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HomeForm";
            this.Text = "MINDBODY 0.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.enso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.ListView clientList;
        private System.Windows.Forms.Label studioName;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.Label classesLabel;
        private System.Windows.Forms.ListView classList;
        private System.Windows.Forms.Button addClientToClass;
        private System.Windows.Forms.Button getSales;
        private System.Windows.Forms.Button updateClient;
        private System.Windows.Forms.Button getClientSchedule;
        private System.Windows.Forms.Label withSelectedClientLabel;
        private System.Windows.Forms.Label andSelectedClassLabel;
        private System.Windows.Forms.Button getClientsAndClasses;
        private System.Windows.Forms.Button getClientServices;
        private System.Windows.Forms.PictureBox enso;
    }
}

