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
        public bool isArchivized { get; set; }

        public Request(string model, string owner, string mark, string description, List<Part> listOfParts, bool archivized)
        {
            Mark = mark;
            Model = model;
            Owner = owner;
            Description = description;
            ListOfParts = listOfParts;
            isArchivized = archivized;
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

        public void AddPartToRequest(Part part)
        {
            ListOfParts.Add(part);
        }

        public void DeletePartFromRequest(int idOfPartToDelete)
        {
            ListOfParts.RemoveAll(part => part.ID == idOfPartToDelete);
        }

        public double GetTotalPrize()
        {
            double TotalPrize = 0;
            foreach (var part in ListOfParts)
            {
                TotalPrize += part.Prize * part.Amount;
            }
            return TotalPrize;
        }
        public static List<Part> GetAllParts(Request request)
        {
            if (request.ListOfParts.Count == 0)
            {
                request.ListOfParts.Add(new Part("coś", 100, 2));
                request.ListOfParts.Add(new Part("coś2", 20, 1));
                request.ListOfParts.Add(new Part("coś3", 1000, 5));
            }
            return request.ListOfParts;
        }
    }
}
