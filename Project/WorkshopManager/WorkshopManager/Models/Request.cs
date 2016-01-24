using System.Collections.Generic;
using System.Linq;
using WorkshopManager.Models.IRequest;

namespace WorkshopManager
{
    public class Request : IRequestWithIdAcces
    {
        public int ID { get; private set; }
        public string Model { get; set; }
        public string Mark { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public List<Part> ListOfParts { get; set; }

        public Request(string model, string owner,string mark, string description, List<Part> listOfParts)
        {
            Mark = mark;
            Model = model;
            Owner = owner;
            Description = description;
            ListOfParts = listOfParts;
        }

        public void SetId(int id)
        {
            ID = id;
        }

        public bool Equals(Request request)
        {
            if (Model != request.Model)
                return false;
            if (Owner != request.Owner)
                return false;
            if (Description != request.Description)
                return false;

            var firstNotSecond = ListOfParts.Except(request.ListOfParts).ToList();
            var secondNotFirst = request.ListOfParts.Except(ListOfParts).ToList();

            return (firstNotSecond.Count == 0 && secondNotFirst.Count == 0);
        }
    }
}
