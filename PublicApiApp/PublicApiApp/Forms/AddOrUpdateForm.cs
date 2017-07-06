using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PublicApiApp.ClientService;
using PublicApiApp.Engines;
using PublicApiApp.Extensions;

namespace PublicApiApp.Forms
{
    public partial class AddOrUpdateForm : Form
    {
        private readonly Client _currentClient;
        private readonly ClientEngine _clientEngine;
        private readonly HomeForm _homeForm;

        public AddOrUpdateForm(Client client, ClientEngine clientEngine, HomeForm homeForm)
        {
            _currentClient = client;
            _clientEngine = clientEngine;
            _homeForm = homeForm;
            InitializeComponent();
        }

        public AddOrUpdateForm(ClientEngine clientEngine, HomeForm homeForm)
        {
            _clientEngine = clientEngine;
            _homeForm = homeForm;
            _currentClient = new Client();
            InitializeComponent();
        }

        private void AddOrUpdateForm_Load(object sender, EventArgs e)
        {
            Text = _currentClient.ID.IsNullOrEmpty() ? "Add New Client" : "Edit Client";
            firstName.Text = _currentClient.FirstName;
            lastName.Text = _currentClient.LastName;
            email.Text = _currentClient.Email;
            phone.Text = _currentClient.MobilePhone;
            save.BackColor = Color.FromArgb(54, 180, 199);
            save.ForeColor = Color.White;
            save.FlatStyle = FlatStyle.Flat;
            save.FlatAppearance.BorderSize = 0;
            save.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void save_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var isNewClient = _currentClient.ID.IsNullOrEmpty();

            _currentClient.FirstName = firstName.Text;
            _currentClient.LastName = lastName.Text;
            _currentClient.Email = email.Text;
            _currentClient.MobilePhone = phone.Text; 
                    
            var updatedClient = _clientEngine.AddOrUpdateClient(_currentClient);
            if (updatedClient != null)
            {              
                _homeForm.HomeForm_Load(null, null); //Reload home form
                Cursor.Current = Cursors.Default;
                Close();   
                MessageBox.Show(isNewClient ? @"Client added!" : @"Client updated!");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
