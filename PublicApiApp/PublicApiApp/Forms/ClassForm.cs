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

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.GridLines = true;
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Start", 150);
            listView1.Columns.Add("End", 150);
            listView1.Columns.Add("Open Spaces", 100);
            
            foreach (var availableClass in _classEngine.GetClasses(clientId))
            {
                listView1.Items.Add(new ListViewItem(new[]
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
    }
}
