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
            this.addClientToClass = new System.Windows.Forms.Button();
            this.updateClient = new System.Windows.Forms.Button();
            this.getClientSchedule = new System.Windows.Forms.Button();
            this.withSelectedClientLabel = new System.Windows.Forms.Label();
            this.enso = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enso)).BeginInit();
            this.SuspendLayout();
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(465, 121);
            this.addClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(136, 28);
            this.addClient.TabIndex = 0;
            this.addClient.Text = "Add a Client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // clientList
            // 
            this.clientList.Location = new System.Drawing.Point(16, 156);
            this.clientList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(584, 234);
            this.clientList.TabIndex = 1;
            this.clientList.UseCompatibleStateImageBehavior = false;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.clientList_SelectedIndexChanged);
            // 
            // studioName
            // 
            this.studioName.AutoSize = true;
            this.studioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studioName.Location = new System.Drawing.Point(16, 15);
            this.studioName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studioName.Name = "studioName";
            this.studioName.Size = new System.Drawing.Size(187, 29);
            this.studioName.TabIndex = 2;
            this.studioName.Text = "MyStudioName";
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Location = new System.Drawing.Point(19, 127);
            this.clientsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(50, 17);
            this.clientsLabel.TabIndex = 3;
            this.clientsLabel.Text = "Clients";
            // 
            // addClientToClass
            // 
            this.addClientToClass.Location = new System.Drawing.Point(16, 505);
            this.addClientToClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addClientToClass.Name = "addClientToClass";
            this.addClientToClass.Size = new System.Drawing.Size(261, 28);
            this.addClientToClass.TabIndex = 7;
            this.addClientToClass.Text = "Add Client to Class";
            this.addClientToClass.UseVisualStyleBackColor = true;
            this.addClientToClass.Click += new System.EventHandler(this.addClientToClass_Click);
            // 
            // updateClient
            // 
            this.updateClient.Location = new System.Drawing.Point(16, 433);
            this.updateClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateClient.Name = "updateClient";
            this.updateClient.Size = new System.Drawing.Size(261, 28);
            this.updateClient.TabIndex = 9;
            this.updateClient.Text = "Update Client";
            this.updateClient.UseVisualStyleBackColor = true;
            // 
            // getClientSchedule
            // 
            this.getClientSchedule.Location = new System.Drawing.Point(16, 469);
            this.getClientSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getClientSchedule.Name = "getClientSchedule";
            this.getClientSchedule.Size = new System.Drawing.Size(261, 28);
            this.getClientSchedule.TabIndex = 10;
            this.getClientSchedule.Text = "Get Schedule";
            this.getClientSchedule.UseVisualStyleBackColor = true;
            // 
            // withSelectedClientLabel
            // 
            this.withSelectedClientLabel.AutoSize = true;
            this.withSelectedClientLabel.Location = new System.Drawing.Point(16, 409);
            this.withSelectedClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.withSelectedClientLabel.Name = "withSelectedClientLabel";
            this.withSelectedClientLabel.Size = new System.Drawing.Size(134, 17);
            this.withSelectedClientLabel.TabIndex = 12;
            this.withSelectedClientLabel.Text = "With selected client:";
            // 
            // enso
            // 
            this.enso.Image = ((System.Drawing.Image)(resources.GetObject("enso.Image")));
            this.enso.Location = new System.Drawing.Point(407, 409);
            this.enso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enso.Name = "enso";
            this.enso.Size = new System.Drawing.Size(195, 124);
            this.enso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enso.TabIndex = 16;
            this.enso.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Today\'s Sales";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enso);
            this.Controls.Add(this.withSelectedClientLabel);
            this.Controls.Add(this.getClientSchedule);
            this.Controls.Add(this.updateClient);
            this.Controls.Add(this.addClientToClass);
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.studioName);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.addClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.Text = "MINDBODY 0.0.1";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.ListView clientList;
        private System.Windows.Forms.Label studioName;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.Button addClientToClass;
        private System.Windows.Forms.Button updateClient;
        private System.Windows.Forms.Button getClientSchedule;
        private System.Windows.Forms.Label withSelectedClientLabel;
        private System.Windows.Forms.PictureBox enso;
        private System.Windows.Forms.Label label1;
    }
}

