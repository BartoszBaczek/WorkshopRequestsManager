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
        public Add Add;
        public Update Update;
        public Delete Delete;

        public PartsTableAdapter()
        {
            Get = new Get();
            Add = new Add();
            Update = new Update();
            Delete = new Delete();
        }
    }
}

namespace PartsTableAdapterExtension
{
    using WorkshopManager.SqlDatabase.MySql;

    class Get
    {
        private const string _table = "Parts";
        private const string _partsTable = "PartsList";
        private const string _allColumns = "id, Name, Price";

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

        public List<string>[] ById(int id)
        {
            return DBConnector.Select(
                _allColumns,
                false,
                _table,
                string.Format("id=\'{0}\'", id));
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
        public List<string>[] ByPrice(double price)
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
        public Dictionary<List<string>, int> PartsList(int idOrder)
        {
            var list = DBConnector.Select(
                "Parts_id, Amount",
                false,
                _partsTable,
                string.Format("Orders_id=\'{0}\'", idOrder));

            if (list[0].Count == 0)
                return null;

            var str = string.Empty;

            for (int i = 0; i < list[0].Count - 1; i++)
            {
                str += string.Format("id=\'{0}\' or ", list[0][i]);
            }
            str += string.Format("id=\'{0}\'", list[0][list[0].Count - 1]);

            var dict = new Dictionary<List<string>, int>();

            var table =  DBConnector.Select(
                _allColumns,
                false,
                _table,
                str);

            for (int i = 0; i < table[0].Count; i++)
            {
                var temp = new List<string>();
                for (int j = 0; j < table.Length; j++)
                {
                    temp.Add(table[j][i]);
                }
                dict.Add(temp, Convert.ToInt32(list[1][i]));
            }
            return dict;
        }
    }

    class Add
    {
        private const string _table = "Parts";
        private const string _allColumns = "Name, Price";

        public int Part(string name, double price)
        {
            DBConnector.Insert(
                _table,
                _allColumns,
                string.Format(
                    "\'{0}\',\'{1}\'", name, price));

            var id = DBConnector.Select(
                    "id",
                    false,
                    _table,
                    string.Format(
                        "Name=\'{0}\' AND Price=\'{1}\'", name, price))[0];

            return Convert.ToInt32(id.Max<string>());
        }
    }

    class Update
    {
        private const string _table = "Parts";

        private string GetWhere(int id)
        {
            return string.Format("id=\'{0}\'", id);
        }

        public void Record(int id, string name, double price)
        {
            DBConnector.Update(
                _table,
                string.Format("Name=\'{0}\', Price=\'{1}\'", name, price),
                GetWhere(id));
        }

        public void Name(int id, string name)
        {
            DBConnector.Update(
                _table,
                string.Format("Name=\'{0}\'", name),
                GetWhere(id));
        }

        public void Price(int id, double price)
        {
            DBConnector.Update(
                _table,
                string.Format("Price=\'{0}\'", price),
                GetWhere(id));
        }
    }

    class Delete
    {
        private const string _table = "Parts";

        public void ByID(int id)
        {
            DBConnector.Delete(
                _table,
                string.Format("id=\'{0}\'", id));
        }

        public void ByName(string name)
        {
            DBConnector.Delete(
                _table,
                string.Format("Name=\'{0}\'", name));
        }

        public void ByPrice(double price)
        {
            DBConnector.Delete(
                _table,
                string.Format("Price=\'{0}\'", price));
        }
    }
}
