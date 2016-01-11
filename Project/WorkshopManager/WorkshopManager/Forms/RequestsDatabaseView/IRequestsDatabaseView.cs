using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WorkshopManager.Forms.RequestsDatabaseView
{
    public enum RequestsCategory
    {
        Active,
        Archivized
    }

    public interface IRequestsDatabaseView
    {
        RequestsDatabasePresenter Presenter { set; }

        object ActiveDataComboBox { get; set; }
        object SelectedActiveData { get; set; }

        DataTable DataGridViewSource { set; }
        DataGridViewRow SelectedRow { get; }
    }
}
