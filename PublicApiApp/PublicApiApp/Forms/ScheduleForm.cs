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

            var bindingSource = new BindingSource();
            foreach (var visit in _clientEngine.GetClientSchedule(clientId, DateTime.Today))
            {
                bindingSource.Add(VisitMapper.Map(visit));
            }

            dataGridView1.DataSource = bindingSource;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

        }

    }
}
