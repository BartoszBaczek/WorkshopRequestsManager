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
        List<Request> GetByMOdel(string model);
        List<Request> GetByOwner(string owner);
        Request GetById(int id);
        void DeleteReqById(int id);
        void UpdateReqById(int id); 
    }
}
