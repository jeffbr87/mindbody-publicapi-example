using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PublicApiApp.ClassService;
using PublicApiApp.ClientService;
using PublicApiApp.Engines;
using PublicApiApp.Helpers;
using PublicApiApp.Models;

namespace PublicApiApp.Forms
{
    public partial class ClassForm : Form
    {
        private readonly ClassEngine _classEngine;
        private readonly ClientEngine _clientEngine;

        private readonly string _clientId;
        private readonly string _clientName;

        private List<ClientService1> _clientServices;
        private List<Class> _classes;

        public ClassForm(string clientId, string clientName)
        {
            _classEngine = new ClassEngine();
            _clientEngine = new ClientEngine();
            _clientId = clientId;
            _clientName = clientName;
            
            InitializeComponent();
            InitializeClassListControl();
            // TODO populate date picker
            PopulateClientServices(DateTime.Now);
            clientNameLabel.Text = clientName;

            _classes = _classEngine.GetClasses(clientId).ToList();
            var classListViewItems = _classes
                .Where(classItem => classItem.ID.HasValue)
                .Select(classItem => new ListViewItem
            {
                Tag = classItem,
                Text = classItem.ID.Value.ToString(),
                SubItems =
                {
                    classItem.ClassDescription.Name,
                    classItem.StartDateTime.ToString(),
                    classItem.EndDateTime.ToString(),
                    (classItem.MaxCapacity - classItem.TotalBooked).ToString()
                }
            }).ToArray();
            ClassListControl.Items.AddRange(classListViewItems);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddClientToClassButton_click(object sender, EventArgs e)
        {
            var clientServiceId = GetSelectedClientService()?.ID;

            var selectedClass = ClassListControl.SelectedItems[0].Tag as Class;
            if (selectedClass?.ID == null)
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Warning, "Please select a class");
                return;
            }

            if (_classEngine.AddClientToClass(_clientId, selectedClass.ID.Value, clientServiceId))
            {
                ScheduleForm form = new ScheduleForm(_clientId, _clientName);
                form.Show();
                Close();
            }
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateFilterBox_ValueChanged(object sender, EventArgs e)
        {

        }

        #region Helpers

        private void InitializeClassListControl()
        {
            ClassListControl.View = View.Details;
            ClassListControl.FullRowSelect = true;
            ClassListControl.MultiSelect = false;
            ClassListControl.GridLines = true;
            ClassListControl.Columns.Add("ID", 100);
            ClassListControl.Columns.Add("Name", 200);
            ClassListControl.Columns.Add("Start", 150);
            ClassListControl.Columns.Add("End", 150);
            ClassListControl.Columns.Add("Open Spaces", 100);
        }

        private void PopulateClientServices(DateTime startDate)
        {
            _clientServices = _clientEngine.GetClientServices(_clientId, startDate).ToList();
            ClientServicesListControl.Items.Clear();
            ClientServicesListControl.Items.AddRange(
                _clientServices.Select(clientService => (object) new ClientServiceItem(clientService)).ToArray());
        }

        private ClientService1 GetSelectedClientService()
        {
            var selected = ClientServicesListControl.SelectedItem as ClientServiceItem;
            return selected == null ? null : _clientServices.FirstOrDefault(item => item.ID == selected.Id);
        }

        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
