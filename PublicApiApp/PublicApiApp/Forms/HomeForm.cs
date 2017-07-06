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
using PublicApiApp.Forms;

namespace PublicApiApp
{
    public partial class HomeForm : Form
    {
        private readonly ClientEngine _clientEngine = new ClientEngine();
        private readonly SalesEngine _salesEngine = new SalesEngine();

        List<Client> _clients = new List<Client>();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void getClientsAndClasses_Click(object sender, EventArgs e)
        {

        }     

        public void HomeForm_Load(object sender, EventArgs e)
        {
            //Sales
            var sales = _salesEngine.GetSales(DateTime.Now.Date, DateTime.Now);
            decimal totalSales = 0;
            foreach (var sale in sales)
            {
                totalSales += sale.Payments[0].Amount;
            }
            label2.Text = $@"${Math.Round(totalSales, 2)}";

            //Buttons - disabled unless client selected
            updateClient.Enabled = false;
            getClientSchedule.Enabled = false;
            addClientToClass.Enabled = false;

            //Searchbox
            searchBox.TextChanged += searchBox_TextChanged;

            //Client list view setup
            clientList.View = View.Details;
            clientList.Scrollable = true;
            clientList.FullRowSelect = true;
            clientList.MultiSelect = false;
            clientList.GridLines = true;
            clientList.Columns.Add("First Name", 100);
            clientList.Columns.Add("Last Name", 100);
            clientList.Columns.Add("Email", 100);
            _clients = _clientEngine.GetClients().OrderBy(c => c.FirstName).ToList();
            foreach (var client in _clients)
            {
                ListViewItem item = new ListViewItem(new []{ client.FirstName, client.LastName, client.Email, client.ID });
                clientList.Items.Add(item);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            ListViewItem foundItem = clientList.FindItemWithText(searchBox.Text, true, 0, true);
            if (foundItem != null)
            {
                clientList.TopItem = foundItem;
            }
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientList.SelectedItems.Count > 0)
            {              
                updateClient.Enabled = true;
                getClientSchedule.Enabled = true;
                addClientToClass.Enabled = true;
            }
        }

        private void addClientToClass_Click(object sender, EventArgs e)
        {
            if (clientList.SelectedItems.Count > 0)
            {
                ClassForm form = new ClassForm(clientList.SelectedItems[0].SubItems[3].Text);
                form.Show();
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            var updateFrm = new AddOrUpdateForm(_clientEngine, this);
            updateFrm.Show();
        }

        private void updateClient_Click(object sender, EventArgs e)
        {
            var selectedClient = clientList.SelectedItems[0];
            var clientId = selectedClient.SubItems[3].Text;           
            var client = _clients.Single(c => c.ID == clientId);
            var updateFrm = new AddOrUpdateForm(client, _clientEngine, this);
            updateFrm.Show();
        }
    }
}
