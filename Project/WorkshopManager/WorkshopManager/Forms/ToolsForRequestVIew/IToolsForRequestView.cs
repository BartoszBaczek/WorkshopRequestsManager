using System.Collections.Generic;

namespace WorkshopManager.Forms.ToolsForRequestView
{
    public interface IToolsForRequestView
    {
        ToolsForRequestPresenter Presenter { set; }
        List<string> AllToolsListBox { get; set; }
        List<string> ToolsForRequestListBox { get; set; }
    }
}
