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
        private readonly ClassEngine classEngine;

        public ClassForm()
        {
            InitializeComponent();
            classEngine = new ClassEngine();

            var bindingSourceForClasses = new BindingSource();
            foreach (var availableClass in classEngine.GetClasses("100014604"))
            {
                bindingSourceForClasses.Add(ClassMapper.Map(availableClass));
            }

            dataGridView1.DataSource = bindingSourceForClasses;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
