using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.DatabasePresenter
{
    interface IPartsDatabaseAdapter
    {
        List<Request> GetAll();
        List<Part> GetByName(string name);
        List<Part> GetByPrize(float prize);
        Part GetById(int id);
        void DeleteParqById(int id);
        void UpdateParById(int id);
 
    }
}
