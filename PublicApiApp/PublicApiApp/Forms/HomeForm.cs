using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PublicApiApp.Engines;
using PublicApiApp.Forms;

namespace PublicApiApp
{
    public partial class HomeForm : Form
    {
        private readonly ClientEngine _clientEngine = new ClientEngine();
        private readonly SalesEngine _salesEngine = new SalesEngine();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void getClientsAndClasses_Click(object sender, EventArgs e)
        {

        }

        private void addClient_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
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
            //Client list view setup
            clientList.View = View.Details;
            clientList.FullRowSelect = true;
            clientList.MultiSelect = false;
            clientList.GridLines = true;
            clientList.Columns.Add("First Name", 100);
            clientList.Columns.Add("Last Name", 100);
            clientList.Columns.Add("Email", 100);
            var clients = _clientEngine.GetClients();
            foreach (var client in clients)
            {
                ListViewItem item = new ListViewItem(new []{ client.FirstName, client.LastName, client.Email, client.ID });
                clientList.Items.Add(item);
            }
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientList.SelectedItems.Count > 0)
            {
                var selectedClient = clientList.SelectedItems[0];
                var clientId = selectedClient.SubItems[3].Text;
                var clientFirstName = selectedClient.SubItems[0].Text;
                var clientLastName = selectedClient.SubItems[1].Text;
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
    }
}
