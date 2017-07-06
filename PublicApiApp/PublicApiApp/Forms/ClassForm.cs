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
using PublicApiApp.Helpers;
using PublicApiApp.Mappers;

namespace PublicApiApp.Forms
{
    public partial class ClassForm : Form
    {
        private readonly ClassEngine _classEngine;

        public ClassForm(string clientId)
        {
            InitializeComponent();
            _classEngine = new ClassEngine();

            ClassListControl.View = View.Details;
            ClassListControl.FullRowSelect = true;
            ClassListControl.MultiSelect = false;
            ClassListControl.GridLines = true;
            ClassListControl.Columns.Add("ID", 100);
            ClassListControl.Columns.Add("Name", 200);
            ClassListControl.Columns.Add("Start", 150);
            ClassListControl.Columns.Add("End", 150);
            ClassListControl.Columns.Add("Open Spaces", 100);
            
            foreach (var availableClass in _classEngine.GetClasses(clientId))
            {
                ClassListControl.Items.Add(new ListViewItem(new[]
                {
                    availableClass.ID.ToString(), availableClass.ClassDescription.Name, availableClass.StartDateTime.ToString(),
                    availableClass.EndDateTime.ToString(), (availableClass.MaxCapacity - availableClass.TotalBooked).ToString()
                }));
            }
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
            // TODO verify a class has been selected
            // TODO Validate date is not in the past... engine?
            int? clientServiceId;

            // TODO probably have to map index to string ID
            var clientServiceIndex = ClientServicesListControl.SelectedIndex;
            
            // TODO same here
            var selectedClasses = ClassListControl.SelectedItems.Cast<int>().ToList();
            if (!selectedClasses.Any())
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Warning, "Please select a class");
                return;
            }
            var classId = selectedClasses.First();
            
            int clientId;

            var success = _classEngine.AddClientToClass(clientId, classId, clientServiceId);

            if (success)
            {
                // TODO close on success and open client class summary screen?
            }

        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateFilterBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
