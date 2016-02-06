using System.CodeDom;
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

        public string ArchivizeUnarchivizeButtonName
        {
            get { return archivizeUnarchivizeButton.Text; }
            set { archivizeUnarchivizeButton.Text = value; }
        }

        public bool ArchivizeUnarchivizeButtonActive 
        {
            get { return archivizeUnarchivizeButton.Enabled; }
            set { archivizeUnarchivizeButton.Enabled = value; }
        }

        public DataGridView DataGridView
        {
            get { return requestsDataGridView; }
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OpenModifierFormForAdding();
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OpenModifierFormForEditing();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OnDeleteSelectedRequest();
        }

        private void generatePDFbutton_Click(object sender, System.EventArgs e)
        {
            Presenter.OnGeneratePDF();
        }

        private void activeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Presenter.OnSelectedActiveDataChanged();
        }

        private void archivizeUnarchivizeButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OnArchivize();
        }
    }
}
