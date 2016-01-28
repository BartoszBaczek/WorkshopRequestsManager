using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.DatabasePresenter
{
    interface IPartsDatabaseAdapter
    {
        List<Part> GetAll();
        List<Part> GetByName(string name);
        List<Part> GetByPrice(double price);
        Part GetById(int id);
        void DeleteById(int idReq, int idPart);
    }
}
