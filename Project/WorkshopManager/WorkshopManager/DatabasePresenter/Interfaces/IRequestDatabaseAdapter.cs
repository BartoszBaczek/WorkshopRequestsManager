using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.DatabasePresenter
{
    interface IRequestDatabaseAdapter
    {
        List<Part> GetByName();
        List<Part> GetByPrize();
        Part GetById();
        void DeleteById(int id);
        void UpdateById(int id); 
    }
}
