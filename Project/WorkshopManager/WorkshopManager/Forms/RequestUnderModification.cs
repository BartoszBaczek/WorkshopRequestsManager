using System.Collections.Generic;

namespace WorkshopManager.Forms.ToolsForRequestVIew
{
    public class RequestUnderModification
    {
        public static Request Value { get; set; }

        private static readonly RequestUnderModification instance = new RequestUnderModification();

        private RequestUnderModification()
        {
            Value = new Request("-", "-", "-", "-", new List<Part>(), true);
        }

        public static RequestUnderModification Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
