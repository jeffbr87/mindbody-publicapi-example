using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PublicApiApp.ClassService;
using PublicApiApp.ClientService;
using PublicApiApp.Engines;
using PublicApiApp.Helpers;
using PublicApiApp.Models;
using Client = PublicApiApp.ClientService.Client;

namespace PublicApiApp.Forms
{
    public partial class ClassForm : Form
    {
        private readonly ClassEngine _classEngine;
        private readonly ClientEngine _clientEngine;
        private readonly Client _client;

        private List<ClientService1> _clientServices;
        private List<Class> _classes;

        private readonly Func<Class, bool> _defaultClassFilter = (classInstance) => true;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="client"></param>
        public ClassForm(Client client)
        {
            _classEngine = new ClassEngine();
            _clientEngine = new ClientEngine();
            _client = client;

            InitializeComponent();
            
            // TODO populate date picker
            PopulateClientServices(DateTime.Now);
            clientNameLabel.Text = client.FirstName + " " + client.LastName;

            // Populate classes
            _classes = _classEngine.GetClasses(_client.ID).ToList();
            PopulateClassList();
        }
        
        /// <summary>
        /// Add client to class button click
        /// </summary>
        private void AddClientToClassButton_click(object sender, EventArgs e)
        {
            var clientServiceId = GetSelectedClientService()?.ID;

            var selectedClass = ClassListControl.SelectedItems[0].Tag as Class;
            if (selectedClass?.ID == null)
            {
                ErrorHelper.DisplayError(ErrorHelper.Severity.Warning, "Please select a class");
                return;
            }

            if (_classEngine.AddClientToClass(_client.ID, selectedClass.ID.Value, clientServiceId))
            {
                ScheduleForm form = new ScheduleForm(_client.ID, _client.FirstName + " " + _client.LastName);
                form.Show();
                Close();
            }
        }

        /// <summary>
        /// Filter class list by search text
        /// </summary>
        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            const StringComparison comparer = StringComparison.CurrentCultureIgnoreCase;
            var filterText = textFilterControl.Text;
            var filter = string.IsNullOrWhiteSpace(filterText)
                ? _defaultClassFilter
                : (classItem) => classItem.ClassDescription.Name.IndexOf(filterText, comparer) >= 0;
            PopulateClassList(filter);
        }

        /// <summary>
        /// Change date filter
        /// </summary>
        private void dateFilterBox_ValueChanged(object sender, EventArgs e)
        {
            // TODO
        }

        #region Helpers

        /// <summary>
        /// Populate client services combo box
        /// </summary>
        /// <param name="startDate"></param>
        private void PopulateClientServices(DateTime startDate)
        {
            _clientServices = _clientEngine.GetClientServices(_client.ID, startDate).ToList();
            ClientServicesListControl.Items.Clear();
            ClientServicesListControl.Items.AddRange(
                _clientServices.Select(clientService => (object) new ClientServiceItem(clientService)).ToArray());
        }

        /// <summary>
        /// Get selected client service item from combo box
        /// </summary>
        /// <returns></returns>
        private ClientService1 GetSelectedClientService()
        {
            var selected = ClientServicesListControl.SelectedItem as ClientServiceItem;
            return selected == null ? null : _clientServices.FirstOrDefault(item => item.ID == selected.Id);
        }

        /// <summary>
        /// Populate the class list
        /// </summary>
        /// <param name="filter">Optional filter for results</param>
        private void PopulateClassList(Func<Class, bool> filter = null)
        {
            var classListViewItems = _classes
                .Where(classInstance => classInstance.ID.HasValue)
                .Where(filter ?? _defaultClassFilter)
                // TODO flexible order by
                .OrderBy(classItem => classItem.StartDateTime)
                .Select(classItem => new ListViewItem
                {
                    Tag = classItem,
                    // Null check happens in LINQ above
                    // ReSharper disable once PossibleInvalidOperationException
                    Text = classItem.ID.Value.ToString(),
                    SubItems =
                    {
                        classItem.ClassDescription.Name,
                        classItem.StartDateTime.ToString(),
                        classItem.EndDateTime.ToString(),
                        (classItem.MaxCapacity - classItem.TotalBooked).ToString()
                    }
                }).ToArray();

            ClassListControl.Items.Clear();
            ClassListControl.Items.AddRange(classListViewItems);
        }

        #endregion

        #region Class Table Drawing

        private static void ClassListControl_FillLastColumn(ListView lv)
        {
            var sum = 0;
            var count = lv.Columns.Count;
            for (var i = 0; i < count - 1; i++)
            {
                sum += lv.Columns[i].Width;
            }
            lv.Columns[count - 1].Width = lv.ClientSize.Width - sum;
        }

        private void ClassListControl_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            const TextFormatFlags cFlag = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;
            e.Graphics.FillRectangle(SystemBrushes.Menu, e.Bounds);
            e.Graphics.DrawRectangle(SystemPens.GradientInactiveCaption, new Rectangle(e.Bounds.X, 0, e.Bounds.Width, e.Bounds.Height));
            var text = ClassListControl.Columns[e.ColumnIndex].Text;
            TextRenderer.DrawText(e.Graphics, text, ClassListControl.Font, e.Bounds, Color.Black, cFlag);
        }

        private void ClassListControl_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            e.Graphics.FillRectangle(SystemBrushes.Menu, e.Bounds);
        }

        private void ClassListControl_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ClassListControl_Resize(object sender, EventArgs e)
        {
            ClassListControl_FillLastColumn((ListView) sender);
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            ClassListControl_FillLastColumn(ClassListControl);
        }

        #endregion
    }
}
