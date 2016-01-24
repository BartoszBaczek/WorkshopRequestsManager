using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.DatabasePresenter
{
    interface IRequestDatabaseAdapter
    {

        List<Request> GetAll();
        List<Request> GetByModel(string model);
        List<Request> GetByOwner(string owner);
        List<Request> GetByMark(string mark);
        Request GetById(int id);
        void AddToDatabase(ref Request newRequest);
        void DeleteById(int id);
        void UpdateRequest(Request updatedRequest); 
    }
}
