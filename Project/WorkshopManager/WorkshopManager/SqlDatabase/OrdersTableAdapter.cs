using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.SqlDatabase
{
    using OrdersTableAdapterExtension;

    class OrdersTableAdapter
    {
        public Get Get;

        public OrdersTableAdapter()
        {
            Get = new Get();
        }
    } 
}

namespace OrdersTableAdapterExtension
{
    using WorkshopManager.SqlDatabase.MySql;
       
    class Get
    {
        private static string _table = "Orders";
        private static string _allColumns = "id, Mark, Model, Owner, Comment, Archive";

        /// <summary>
        /// Zwraca tablicę list stringów zawierającą kompletną tabelę 'Orders'
        /// </summary>
        /// <returns></returns>
        public List<string>[] All()
        {
            return  DBConnector.Select(
                _allColumns,
                false,
                _table,
                "");
        }

        /// <summary>
        /// Zwraca tablicę list stringów zawierającą wszystkie rekordy z tabeli 'Orders' o podanej marce
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public List<string>[] ByMark(string mark)
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                string.Format("Mark=\'{0}\'", mark));
        }

        /// <summary>
        /// Zwraca tablicę list stringów zawierającą wszystkie rekordy z tabeli 'Orders' o podanym modelu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<string>[] ByModel(string model)
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                string.Format("Model=\'{0}\'", model));
        }

        /// <summary>
        /// Zwraca tablicę list stringów zawierającą rekordy pasujące do danego właściciela
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public List<string>[] ByOwner(string owner)
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                string.Format("Owner=\'{0}\'", id));
        }

        /// <summary>
        /// Zwraca tablicę list stringów zawierającą rekord o podanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

