using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager
{
    class Request
    {
        public int id;
        public string model;
        public string owner;
        public string description;
        public List<Part> listOfParts;

    Request(int _id, string _model, string _owner, string _description, List<Part> _listOfParts)
        {
            model = _model;
            owner = _owner;
            description = _description;
            listOfParts = _listOfParts;

        }
        
    }
}
