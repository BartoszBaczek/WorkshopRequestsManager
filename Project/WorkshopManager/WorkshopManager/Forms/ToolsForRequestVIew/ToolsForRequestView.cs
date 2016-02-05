using System.Collections.Generic;
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

        public List<string> AllToolsListBox
        {
            get { return allToolsListBox.DataSource as List<string>; }
            set { allToolsListBox.DataSource = value; }
        }

        public List<string> ToolsForRequestListBox
        {
            get { return toolsForRequestListBox.DataSource as List<string>; }
            set { toolsForRequestListBox.DataSource = value; }
        }
    }
}
    