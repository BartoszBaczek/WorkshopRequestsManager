using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace WorkshopManager.Models
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
