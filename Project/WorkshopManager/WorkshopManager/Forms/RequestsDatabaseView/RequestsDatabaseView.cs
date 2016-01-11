using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WorkshopManager.Forms.RequestsDatabaseView
{
    public partial class RequestsDatabaseForm : Form, IRequestsDatabaseView
    {
        public RequestsDatabasePresenter Presenter { private get; set; }

        public RequestsDatabaseForm()
        {
            InitializeComponent();
            new RequestsDatabasePresenter(this);

        }

        public object ActiveDataComboBox
        {
            get { return activeComboBox.DataSource; }
            set { activeComboBox.DataSource = value; }
        }

        public object SelectedActiveData
        {
            get { return activeComboBox.SelectedItem; }
            set { activeComboBox.SelectedItem = value; }
        }

        public DataTable DataGridViewSource
        {
            set { requestsDataGridView.DataSource = value; }
        }

        public DataGridViewRow SelectedRow
        {
            get { return requestsDataGridView.SelectedRows[0]; }
        }
    }
}
