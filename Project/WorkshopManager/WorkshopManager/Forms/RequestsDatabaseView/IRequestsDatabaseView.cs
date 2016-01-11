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

        List<string> ActiveDataComboBox { get; set; }
        int SelectedActiveData { get; set; }

        DataTable DataGridViewSource { set; }
        DataGridView DataGridView { get; }
        DataGridViewRow SelectedRow { get; }
    }
}
