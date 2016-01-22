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
        public Get Get;
        public Add Add;
        public Update Update;
        public Delete Delete;

        public PartsListTableAdapter()
        {
            Get = new Get();
            Add = new Add();
            Update = new Update();
            Delete = new Delete();
        }
    }
}

namespace PartsListTableAdapterExtensions
{
    using WorkshopManager.SqlDatabase.MySql;

    class Get
    {

    }

    class Add
    {
        private const string _listTable = "PartsList";
        private const string _allColumns = "Parts_id, Orders_id";

        public void Single(int idOrder, int idPart)
        {
            DBConnector.Insert(
                _listTable,
                _allColumns,
                string.Format("{0},{1}", idPart, idOrder));
        }

        public void Multiple(int idOrder, List<int> idParts)
        {
            List<string> records = new List<string>();

            foreach (var item in idParts)
            {
                records.Add(
                    string.Format(
                        "{0},{1}", item, idOrder));
            }

            DBConnector.Insert(
                _listTable,
                _allColumns,
                records);
        }
    }

    class Update
    {

    }

    class Delete
    {

    }
}
