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

        public List<string> ActiveDataComboBox
        {
            get { return (List<string>) activeComboBox.DataSource; }
            set { activeComboBox.DataSource = value; }
        }

        public int SelectedActiveData
        {
            get { return activeComboBox.SelectedIndex; }
            set { activeComboBox.SelectedIndex = value; }
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
