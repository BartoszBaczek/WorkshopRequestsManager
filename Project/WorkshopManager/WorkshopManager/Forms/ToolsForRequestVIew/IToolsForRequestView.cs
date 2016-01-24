using System.Collections.Generic;

namespace WorkshopManager.Forms.ToolsForRequestView
{
    public interface IToolsForRequestView
    {
        ToolsForRequestPresenter Presenter { set; }
        List<object> AllToolsListBox { get; set; }
        List<object> ToolsForRequestListBox { get; set; 
    }
}
