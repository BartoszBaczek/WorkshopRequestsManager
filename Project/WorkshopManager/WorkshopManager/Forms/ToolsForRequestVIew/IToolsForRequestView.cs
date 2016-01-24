using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManager.Forms.ToolsForRequestVIew
{
    public interface IToolsForRequestView
    {
        List<Part> allPartsListBox { get; set; }
        List<Part> requestPartsListBox { get; set; } 
    }
}
