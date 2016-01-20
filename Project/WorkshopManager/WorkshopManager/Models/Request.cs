using System.Collections.Generic;

namespace WorkshopManager
{
    public class Request
    {
        public int ID { get; private set; }     //ID tak samo jak w Part
        public string Model { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public List<Part> ListOfParts { get; set; }

        public Request(int id, string model, string owner, string description, List<Part> listOfParts)
        {
            ID = id;
            Model = model;
            Owner = owner;
            Description = description;
            ListOfParts = listOfParts;
        }

    }
}
