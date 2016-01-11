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
        }

        public List<string> ActiveDataComboBox
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public int SelectedActiveData
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public DataTable DataGridViewSource
        {
            set { throw new System.NotImplementedException(); }
        }

        public DataGridView DataGridView
        {
            get { throw new System.NotImplementedException(); }
        }

        public DataGridViewRow SelectedRow
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
