using System.Collections.Generic;
using System.Windows.Forms;

namespace WorkshopManager.Forms.ToolsForRequestView
{
    public partial class ToolsForRequest : Form, IToolsForRequestView
    {
        public ToolsForRequestPresenter Presenter { private get; set; }

        public ToolsForRequest()
        {
            InitializeComponent();
        }


        public List<object> AllToolsListBox
        {
            get { return allToolsListBox.DataSource as List<object>; }
            set { allToolsListBox.DataSource = value; }
        }

        public List<object> ToolsForRequestListBox
        {
            get { return toolsForRequestListBox.DataSource as List<object>; }
            set { toolsForRequestListBox.DataSource = value; }
        }
    }
}
