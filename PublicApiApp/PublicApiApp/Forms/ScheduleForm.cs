using PublicApiApp.Engines;
using System;
using System.Windows.Forms;
using PublicApiApp.Mappers;

namespace PublicApiApp.Forms
{
    public partial class ScheduleForm : Form
    {
        private readonly ClientEngine _clientEngine;

        public ScheduleForm(string clientId, string clientName)
        {
            InitializeComponent();
            _clientEngine = new ClientEngine();
            scheduleLabel.Text = clientName + @"'s schedule at a glance";

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.GridLines = true;
            listView1.Columns.Add("Day", 100);
            listView1.Columns.Add("Date", 70);
            listView1.Columns.Add("Start", 60);
            listView1.Columns.Add("End", 60);
            listView1.Columns.Add("Name", 120);
            listView1.Columns.Add("Signed In", 60);
            listView1.Columns.Add("Location", 90);
            listView1.Columns.Add("Staff", 100);

            foreach (var visit in _clientEngine.GetClientSchedule(clientId, DateTime.Today))
            {
                listView1.Items.Add(new ListViewItem(new[]
                {
                    visit.StartDateTime.DayOfWeek.ToString(),
                    visit.StartDateTime.Date.ToShortDateString(),
                    visit.StartDateTime.ToShortTimeString(),
                    visit.EndDateTime.ToShortTimeString(),
                    visit.Name,
                    visit.SignedIn.ToString(),
                    visit.Location?.Name,
                    visit.Staff?.Name
                }));
            }
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
