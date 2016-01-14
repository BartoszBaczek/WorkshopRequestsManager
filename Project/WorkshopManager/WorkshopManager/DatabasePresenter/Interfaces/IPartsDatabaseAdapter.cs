using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.DatabasePresenter
{
    interface IPartsDatabaseAdapter
    {
        List<Request> GetByMOdel();
        List<Request> GetByOwner();
        Request GetById();
        void DeleteById(int id);
        void UpdateById(int id); 
 
    }
}
