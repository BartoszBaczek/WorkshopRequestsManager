using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.Forms.RequestsDatabaseView
{
    public class RequestsDataTableCreator
    {
        private DataTable _requestsDataTable;

        public RequestsDataTableCreator()
        {
            _requestsDataTable = new DataTable();
            CreateColumns();
        }

        private void CreateColumns()
        {
            _requestsDataTable.Columns.Add("ID", typeof (int));
            _requestsDataTable.Columns.Add("Model", typeof(string));
            _requestsDataTable.Columns.Add("Mark", typeof (string));
            _requestsDataTable.Columns.Add("Owner", typeof (string));
            _requestsDataTable.Columns.Add("Description", typeof (string));
        }

        public void UpdateRows(IEnumerable<Request> requestsToBind)
        {
            foreach (var request in requestsToBind)
            {
                DataRow newRow = _requestsDataTable.NewRow();

                newRow["ID"] = request.ID;
                newRow["Model"] = request.Model;
                newRow["Mark"] = request.Mark;
                newRow["Owner"] = request.Owner;
                newRow["Description"] = request.Description;
                _requestsDataTable.Rows.Add(newRow);
            }
        }

        public DataTable GetCurrentDataTable()
        {
            return _requestsDataTable;
        }
    }
}
