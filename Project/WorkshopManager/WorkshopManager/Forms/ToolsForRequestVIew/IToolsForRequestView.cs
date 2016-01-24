using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.Forms.ToolsForRequestView
{
    public interface IToolsForRequestView
    {
        ToolsForRequestPresenter Presenter { set; }
        List<Part> AllToolsListBox { get; set; }
        List<Part> ToolsForRequestListBox { get; set; } 
    }
}
