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
        private static string _partsTable = "PartsList";
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

        /// <summary>
        /// Zwraca tablicę list stringów zawierającą wszystkie rekordy z tabeli 'Parts'
        /// które w tabeli 'PartsList' zostały przypisane do podanego id z tabeli 'Orders'
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<string>[] PartsList(int id)
        {
            var list = DBConnector.Select(
                "Parts_id",
                false,
                _partsTable,
                string.Format("Orders_id=\'{0}\'", id))[0];

            var str = string.Empty;

            for (int i = 0; i < list.Count - 1; i++)
            {
                str += string.Format("id=\'{0}\' or ", list[i]);
            }
            str += string.Format("id=\'{0}\'", list[list.Count - 1]);

            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                str);
        }
    }
}
