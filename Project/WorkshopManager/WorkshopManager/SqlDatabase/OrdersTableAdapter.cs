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
        public Add Add;
        public Update Update;
        public Delete Delete;

        public OrdersTableAdapter()
        {
            Get = new Get();
            Add = new Add();
            Update = new Update();
            Delete = new Delete();
        }
    } 
}

namespace OrdersTableAdapterExtension
{
    using WorkshopManager.SqlDatabase.MySql;
       
    class Get
    {
        private const string _table = "Orders";
        private const string _allColumns = "id, Mark, Model, Owner, Comment, Archive";

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
                string.Format("Owner=\'{0}\'", owner));
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

    class Add
    {
        private const string _table = "Orders";
        private const string _allColumns = "Mark, Model, Owner, Comment, Archive";

        public int Order(string mark, string model, string owner, string comment)
        {
            DBConnector.Insert(
                _table,
                _allColumns,
                string.Format(
                    "\'{0}\',\'{1}\',\'{2}\',\'{3}\',0", mark, model, owner, comment));

            var id = DBConnector.Select(
                    "id",
                    false,
                    _table,
                    string.Format(
                        "Mark=\'{0}\' AND Model=\'{1}\' AND Owner=\'{2}\'", mark, model, owner))[0];

            return Convert.ToInt32(id.Max<string>());
        }
    }

    class Update
    {
        private const string _table = "Orders";

        private string GetWhere(int id)
        {
            return string.Format("id=\'{0}\'", id);
        }

        public void Record(int id, string mark, string model, string owner, string comment)
        {
            DBConnector.Update(
                _table,
                string.Format("Mark=\'{0}\', Model=\'{1}\', Owner=\'{2}\', Comment=\'{3}\'", mark, model, owner, comment),
                GetWhere(id));
        }

        public void Mark(int id, string mark)
        {
            DBConnector.Update(
                _table,
                string.Format("Mark=\'{0}\'", mark),
                GetWhere(id));
        }

        public void Model(int id, string model)
        {
            DBConnector.Update(
                _table,
                string.Format("Model=\'{0}\'", model),
                GetWhere(id));
        }

        public void Owner(int id, string owner)
        {
            DBConnector.Update(
                _table,
                string.Format("Owner=\'{0}\'", owner),
                GetWhere(id));
        }

        public void Comment(int id, string comment)
        {
            DBConnector.Update(
                _table,
                string.Format("Comment=\'{0}\'", comment),
                GetWhere(id));
        }

        public void Archive(int id)
        {
            DBConnector.Update(
                _table,
                string.Format("Archive=\'{0}\'", 1),
                GetWhere(id));
        }
    }

    class Delete
    {
        private const string _table = "Orders";

        public void ByID(int id)
        {
            DBConnector.Delete(
                _table,
                string.Format("id=\'{0}\'", id));
        }

        public void ByMark(string mark)
        {
            DBConnector.Delete(
                _table,
                string.Format("Mark=\'{0}\'", mark));
        }

        public void ByModel(string model)
        {
            DBConnector.Delete(
                _table,
                string.Format("Model=\'{0}\'", model));
        }

        public void ByOwner(string owner)
        {
            DBConnector.Delete(
                _table,
                string.Format("Owner=\'{0}\'", owner));
        }

        public void ByArchive(bool archive)
        {
            var value = (archive) ? 1 : 0;

            DBConnector.Delete(
                _table,
                string.Format("Archive=\'{0}\'", value));
        }
    }
}

