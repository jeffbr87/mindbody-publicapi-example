using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PublicApiApp.ClientService;
using PublicApiApp.Engines;
using PublicApiApp.Helpers;

namespace PublicApiApp.Forms
{
    public partial class HomeForm : Form
    {
        private readonly ClientEngine _clientEngine = new ClientEngine();
        private readonly SalesEngine _salesEngine = new SalesEngine();

        /// <summary>
        /// Constructor
        /// </summary>
        public HomeForm()
        {
            InitializeComponent();
        }   

        /// <summary>
        /// Home form loader
        /// </summary>
        public void HomeForm_Load(object sender, EventArgs e)
        {            
            // Sales
            var sales = _salesEngine.GetSales(DateTime.Now.Date, DateTime.Now);
            var totalSales = Math.Round(sales.Sum(sale => sale.Payments[0].Amount), 2);

            label2.Text = $@"${totalSales}";

            // Buttons - disabled unless client selected
            updateClient.Enabled = false;
            getClientSchedule.Enabled = false;
            addClientToClass.Enabled = false;
            addClient.BackColor = Color.FromArgb(54, 180, 199);
            addClient.ForeColor = Color.White;
            addClient.FlatStyle = FlatStyle.Flat;
            addClient.FlatAppearance.BorderSize = 0;
            addClient.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            // Searchbox
            searchBox.TextChanged += searchBox_TextChanged;

            // Client list view setup
            clientList.View = View.Details;
            clientList.Scrollable = true;
            clientList.FullRowSelect = true;
            clientList.MultiSelect = false;
            clientList.GridLines = true;
            clientList.Columns.Add("First Name", 120);
            clientList.Columns.Add("Last Name", 120);
            clientList.Columns.Add("Email", 175);  
            PopulateClientList();         
        }

        /// <summary>
        /// Populate client list with clients
        /// </summary>
        public void PopulateClientList()
        {
            clientList.Items.Clear();
            var clients = _clientEngine.GetClients().OrderBy(c => c.FirstName).ToList();
            var clientListItems = clients.Select(clientItem => new ListViewItem { 
                Tag = clientItem,
                Text = clientItem.FirstName,
                SubItems =
                {
                    clientItem.LastName?.ToString() ?? "",
                    clientItem.Email?.ToString() ?? "",
                    clientItem.ID?.ToString() ?? ""
                }
            }).ToArray();
           clientList.Items.AddRange(clientListItems);         
           studioName.Text = clients.FirstOrDefault(c => c.HomeLocation?.Name != null)?.HomeLocation.Name ?? "My Studio";
        }

        /// <summary>
        /// Search box text change
        /// </summary>
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var foundItem = clientList.FindItemWithText(searchBox.Text, true, 0, true);
            if (foundItem != null)
            {
                clientList.TopItem = foundItem;
            }
        }

        /// <summary>
        /// Client list index change
        /// </summary>
        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientList.SelectedItems.Count == 0)
            {
                return;
            }

            updateClient.Enabled = true;
            getClientSchedule.Enabled = true;
            addClientToClass.Enabled = true;
        }

        /// <summary>
        /// Add client to class button click
        /// </summary>
        private void addClientToClass_Click(object sender, EventArgs e)
        {
            if (clientList.SelectedItems.Count == 0)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            var selectedClient = clientList.SelectedItems[0].Tag as Client;
            if (selectedClient?.ID == null)
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Warning, "Please select a client");
                return;
            }

            new ClassForm(selectedClient).Show();

            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Add new client button click
        /// </summary>
        private void addClient_Click(object sender, EventArgs e)
        {
            var updateFrm = new AddOrUpdateForm(_clientEngine, this);
            updateFrm.Show();
        }

        /// <summary>
        /// Update client button click
        /// </summary>
        private void updateClient_Click(object sender, EventArgs e)
        {
            var selectedClient = clientList.SelectedItems[0].Tag as Client;
            if (selectedClient?.ID == null)
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Warning, "Please select a client");
            }
            var updateFrm = new AddOrUpdateForm(selectedClient, _clientEngine, this);
            updateFrm.Show();
        }

        /// <summary>
        /// Get client schedule button click
        /// </summary>
        private void getClientSchedule_Click(object sender, EventArgs e)
        {
            if (clientList.SelectedItems.Count <= 0)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            var selectedClient = clientList.SelectedItems[0].Tag as Client;
            if (selectedClient?.ID == null)
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Warning, "Please select a client");
                return;
            }

            new ScheduleForm(selectedClient.ID, $"{selectedClient.FirstName} {selectedClient.LastName}").Show();

            Cursor.Current = Cursors.Default;
        }
    }
}
