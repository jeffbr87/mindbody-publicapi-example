using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PublicApiApp.Forms;

namespace PublicApiApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void getClientsAndClasses_Click(object sender, EventArgs e)
        {
            ClassForm classForm = new ClassForm();
            classForm.Show();
        }

        private void addClient_Click(object sender, EventArgs e)
        {

        }
    }
}
