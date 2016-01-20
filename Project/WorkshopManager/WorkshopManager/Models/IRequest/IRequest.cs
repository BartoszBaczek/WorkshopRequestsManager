using System.Collections.Generic;

namespace WorkshopManager.Models.IRequest
{
    public interface IRequest
    {
        int ID { get; }
        string Model { get; set; }
        string Owner { get; set; }
        string Description { get; set; }
        List<Part> ListOfParts { get; set; } 
    }
}
