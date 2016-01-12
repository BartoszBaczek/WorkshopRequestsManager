using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.SqlDatabase
{
    using PartsTableAdapterExtension;

    class PartsTableAdapter
    {
    }
}

namespace PartsTableAdapterExtension
{
    using WorkshopManager.SqlDatabase.MySql;

    class Get
    {
        private static string _table = "Parts";
        private static string _allColumns = "id, Name, Price";

        public List<string>[] All()
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                "");
        }

        public List<string>[] ByName(string name)
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                string.Format("Name=\'{0}\'", name));
        }

        public List<string>[] ByPrice(float price)
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                string.Format("Price=\'{0}\'", price));
        }
    }
}
