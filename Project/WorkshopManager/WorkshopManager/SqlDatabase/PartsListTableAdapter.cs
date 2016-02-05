using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.SqlDatabase
{
    using PartsListTableAdapterExtensions;

    class PartsListTableAdapter
    {
        public Add Add;
        public Update Update;
        public Delete Delete;

        public PartsListTableAdapter()
        {
            Add = new Add();
            Update = new Update();
            Delete = new Delete();
        }
    }
}

namespace PartsListTableAdapterExtensions
{
    using WorkshopManager.SqlDatabase.MySql;

    class Add
    {
        private const string _listTable = "PartsList";
        private const string _allColumns = "Parts_id, Orders_id, Amount";

        public void Single(int idOrder, int idPart, int amount)
        {
            DBConnector.Insert(
                _listTable,
                _allColumns,
                string.Format("{0},{1},{2}", idPart, idOrder, amount));
        }

        public void Multiple(int idOrder, Dictionary<int, int> idParts)
        {
            List<string> records = new List<string>();

            foreach (var item in idParts)
            {
                records.Add(
                    string.Format(
                        "{0},{1},{2}", item.Key, idOrder, item.Value));
            }

            DBConnector.Insert(
                _listTable,
                _allColumns,
                records);
        }
    }

    class Update
    {
        private const string _listTable = "PartsList";

        public void Part(int idOrder, int idPart, int amount)
        {
            DBConnector.Update(
                _listTable,
                string.Format(
                    "Amount=\'{0}\'",
                    amount),
                string.Format(
                    "Orders_id=\'{0}\' and Parts_id=\'{1}\'",
                    idOrder, idPart));
        }
    }

    class Delete
    {
        private const string _listTable = "PartsList";

        public void List(int idOrder)
        {
            DBConnector.Delete(
                _listTable,
                string.Format(
                    "Orders_id=\'{0}\'", idOrder));
        }

        public void Part(int idOrder, int idPart)
        {
            DBConnector.Delete(
                _listTable,
                string.Format(
                    "Orders_id=\'{0}\' and Parts_id=\'{1}\'",
                    idOrder, idPart));
        }
    }
}
