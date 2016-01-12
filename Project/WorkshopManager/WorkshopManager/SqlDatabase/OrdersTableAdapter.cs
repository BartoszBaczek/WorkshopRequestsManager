using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.SqlDatabase
{
    using Extension;

    class OrdersTableAdapter
    {
        public Get Get;

        public OrdersTableAdapter()
        {
            Get = new Get();
        }
    } 
}

namespace Extension
{
    using WorkshopManager.SqlDatabase;
       
    class Get
    {
        private static string _table = "Orders";
        private static string _allColumns = "id, Mark, Model, Owner, Comment, Archive";

        public List<string>[] All()
        {
            return  DBConnector.Select(
                _allColumns,
                false,
                _table,
                "");
        }

        public List<string>[] ByMark(string mark)
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                string.Format("Mark=\'{0}\'", mark));
        }

        public List<string>[] ByModel(string model)
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                string.Format("Model=\'{0}\'", model));
        }

        public List<string>[] ById(int id)
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                string.Format("id=\'{0}\'", id));
        }
    }
}

