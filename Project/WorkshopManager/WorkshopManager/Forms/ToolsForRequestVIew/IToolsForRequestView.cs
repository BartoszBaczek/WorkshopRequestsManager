using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WorkshopManager.Forms.ToolsForRequestView
{
    public interface IToolsForRequestView
    {
        ToolsForRequestPresenter Presenter { set; }

        DataTable AllPartsDataGridViewSource { set; }
        DataGridViewRow AllPartsSelectedRow { get ; }

        DataTable RequestPartsDataGridViewSource { set; }
        DataGridViewRow RequestPartsSelectedRow { get; }

        int QuantityOfPartsToMoveAtOnce { get; set; }
    }
}
