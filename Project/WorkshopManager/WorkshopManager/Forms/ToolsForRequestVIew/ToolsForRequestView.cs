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
            get
            {
                return requestPartsDataGridView.SelectedRows.Count == 0 ? null : requestPartsDataGridView.SelectedRows[0];
            }
        }

        public int QuantityOfPartsToMoveAtOnce
        {
            get
            {
                int n;
                if (Int32.TryParse(quantityToMoveAtOnceTextBox.Text, out n))
                    return n;

                    QuantityOfPartsToMoveAtOnce = 1;
                    return 1;
            }
            set { quantityToMoveAtOnceTextBox.Text = value.ToString(); }
        }


        private void moveFewToRequestButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OnMoveToRequestButtonClicked();
        }

        private void DeleteFromRequestButton_Click(object sender, EventArgs e)
        {
            Presenter.OnDeleteFromRequestButtonClicked();
        }
    }
}
    