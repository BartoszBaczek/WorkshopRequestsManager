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
        public Get Get;

        public PartsTableAdapter()
        {
            Get = new Get();
        }
    }
}

namespace PartsTableAdapterExtension
{
    using WorkshopManager.SqlDatabase.MySql;

    class Get
    {
        private static string _table = "Parts";
        private static string _allColumns = "id, Name, Price";

        /// <summary>
        /// Zwraca tablicę list stringów zawierającą kompletną tabelę 'Parts'
        /// </summary>
        /// <returns></returns>
        public List<string>[] All()
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                "");
        }

        /// <summary>
        /// Zwraca tablicę list stringów zawierającą wszystkie rekordy z tabeli 'Parts' o podanej Nazwie
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<string>[] ByName(string name)
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                string.Format("Name=\'{0}\'", name));
        }

        /// <summary>
        /// Zwraca tablicę list stringów zawierającą wszystkie rekordy z tabeli 'Parts' o podanej Cenie
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
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
