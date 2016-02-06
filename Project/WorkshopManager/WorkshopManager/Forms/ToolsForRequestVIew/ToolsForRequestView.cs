using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WorkshopManager.Forms.ToolsForRequestView
{
    public partial class ToolsForRequestView : Form, IToolsForRequestView
    {
        public ToolsForRequestPresenter Presenter { private get; set; }

        public ToolsForRequestView()
        {
            InitializeComponent();
            Presenter = new ToolsForRequestPresenter(this);
        }

        public DataTable AllPartsDataGridViewSource
        {
            set { allPartsDataGridView.DataSource = value; }
        }

        public DataGridViewRow AllPartsSelectedRow
        {
            get { return allPartsDataGridView.SelectedRows[0]; }
        }

        public DataTable RequestPartsDataGridViewSource
        {
            set { requestPartsDataGridView.DataSource = value; }
        }

        public DataGridViewRow RequestPartsSelectedRow
        {
            get { return requestPartsDataGridView.SelectedRows[0]; }
        }

        public int QuantityOfPartsToMoveAtOnce
        {
            get { return Int32.Parse(quantityToMoveAtOnceTextBox.Text); }
            set { quantityToMoveAtOnceTextBox.Text = value.ToString(); }
        }


        private void moveSingleToAllButton_Click(object sender, System.EventArgs e)
        {

        }

        private void moveFewToAllButton_Click(object sender, System.EventArgs e)
        {

        }

        private void mvoeSingleToRequestButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OnMoveSingleToRequestButtonClicked();
        }

        private void moveFewToRequestButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OnMoveFewToRequestButtonClicked();
        }
    }
}
    