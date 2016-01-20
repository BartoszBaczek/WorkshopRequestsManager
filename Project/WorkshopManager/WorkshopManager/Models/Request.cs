using System.Collections.Generic;
using WorkshopManager.Models.IRequest;

namespace WorkshopManager
{
    public class Request : IRequestWithIdAcces
    {
        public int ID { get; private set; }
        public string Model { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public List<Part> ListOfParts { get; set; }

        public Request(string model, string owner, string description, List<Part> listOfParts)
        {
            Model = model;
            Owner = owner;
            Description = description;
            ListOfParts = listOfParts;
        }

        public void SetId(int id)
        {
            ID = id;
        }
    }
}
