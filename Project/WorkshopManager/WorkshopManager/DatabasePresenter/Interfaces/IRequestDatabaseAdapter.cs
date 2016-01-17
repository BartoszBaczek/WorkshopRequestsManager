using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.DatabasePresenter
{
    interface IRequestDatabaseAdapter
    {
        List<Part> GetByName(string name);
        List<Part> GetByPrize(float prize);
        Part GetById(int id);
        void DeleteById(int id);
        void UpdateById(int id); 
    }
}
