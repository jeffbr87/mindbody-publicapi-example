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
            this.salesTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enso)).BeginInit();
            this.SuspendLayout();
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(349, 82);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(102, 23);
            this.addClient.TabIndex = 0;
            this.addClient.Text = "Add a Client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // clientList
            // 
            this.clientList.Location = new System.Drawing.Point(12, 111);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(439, 191);
            this.clientList.TabIndex = 1;
            this.clientList.UseCompatibleStateImageBehavior = false;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.clientList_SelectedIndexChanged);
            // 
            // studioName
            // 
            this.studioName.AutoSize = true;
            this.studioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studioName.Location = new System.Drawing.Point(10, 11);
            this.studioName.Name = "studioName";
            this.studioName.Size = new System.Drawing.Size(147, 25);
            this.studioName.TabIndex = 2;
            this.studioName.Text = "MyStudioName";
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Location = new System.Drawing.Point(14, 87);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(38, 13);
            this.clientsLabel.TabIndex = 3;
            this.clientsLabel.Text = "Clients";
            // 
            // addClientToClass
            // 
            this.addClientToClass.Location = new System.Drawing.Point(12, 394);
            this.addClientToClass.Name = "addClientToClass";
            this.addClientToClass.Size = new System.Drawing.Size(196, 23);
            this.addClientToClass.TabIndex = 7;
            this.addClientToClass.Text = "Add Client to Class";
            this.addClientToClass.UseVisualStyleBackColor = true;
            // 
            // updateClient
            // 
            this.updateClient.Location = new System.Drawing.Point(12, 336);
            this.updateClient.Name = "updateClient";
            this.updateClient.Size = new System.Drawing.Size(196, 23);
            this.updateClient.TabIndex = 9;
            this.updateClient.Text = "Update Client";
            this.updateClient.UseVisualStyleBackColor = true;
            // 
            // getClientSchedule
            // 
            this.getClientSchedule.Location = new System.Drawing.Point(12, 365);
            this.getClientSchedule.Name = "getClientSchedule";
            this.getClientSchedule.Size = new System.Drawing.Size(196, 23);
            this.getClientSchedule.TabIndex = 10;
            this.getClientSchedule.Text = "Get Schedule";
            this.getClientSchedule.UseVisualStyleBackColor = true;
            // 
            // withSelectedClientLabel
            // 
            this.withSelectedClientLabel.AutoSize = true;
            this.withSelectedClientLabel.Location = new System.Drawing.Point(12, 316);
            this.withSelectedClientLabel.Name = "withSelectedClientLabel";
            this.withSelectedClientLabel.Size = new System.Drawing.Size(103, 13);
            this.withSelectedClientLabel.TabIndex = 12;
            this.withSelectedClientLabel.Text = "With selected client:";
            // 
            // enso
            // 
            this.enso.Image = ((System.Drawing.Image)(resources.GetObject("enso.Image")));
            this.enso.Location = new System.Drawing.Point(305, 316);
            this.enso.Name = "enso";
            this.enso.Size = new System.Drawing.Size(146, 101);
            this.enso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enso.TabIndex = 16;
            this.enso.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Today\'s Sales:";
            // 
            // salesTotalLabel
            // 
            this.salesTotalLabel.AutoSize = true;
            this.salesTotalLabel.Location = new System.Drawing.Point(94, 55);
            this.salesTotalLabel.Name = "salesTotalLabel";
            this.salesTotalLabel.Size = new System.Drawing.Size(83, 13);
            this.salesTotalLabel.TabIndex = 18;
            this.salesTotalLabel.Text = "SalesTotalLabel";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 435);
            this.Controls.Add(this.salesTotalLabel);
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
        private System.Windows.Forms.Label salesTotalLabel;
    }
}

