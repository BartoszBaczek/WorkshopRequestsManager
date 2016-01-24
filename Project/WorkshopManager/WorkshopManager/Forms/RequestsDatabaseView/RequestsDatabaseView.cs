using System.Data;
using System.Windows.Forms;

namespace WorkshopManager.Forms.RequestsDatabaseView
{
    public partial class RequestsDatabaseView : Form, IRequestsDatabaseView
    {
        public RequestsDatabasePresenter Presenter { private get; set; }

        public RequestsDatabaseView()
        {
            InitializeComponent();
            new RequestsDatabasePresenter(this);

            var pta = new SqlDatabase.PartsTableAdapter();
            pta.Get.PartsList(2);

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

        private void addButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OpenModifierFormForAdding();
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OpenModifierFormForEditing();
        }
    }
}
