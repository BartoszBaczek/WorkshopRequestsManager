using System.Collections.Generic;
using System.Data;

namespace WorkshopManager.Forms.ToolsForRequestVIew
{
    public class ToolsForRequestDataTableCreator
    {
        private DataTable _allPartsDataTable;
        private DataTable _requestPartsDataTable;

        public ToolsForRequestDataTableCreator()
        {
            _allPartsDataTable = new DataTable();
            _requestPartsDataTable = new DataTable();

            CreateColumns();
        }

        private void CreateColumns()
        {
            _allPartsDataTable.Columns.Add("ID", typeof(int));
            _allPartsDataTable.Columns.Add("Name", typeof(string));
            _allPartsDataTable.Columns.Add("Prize", typeof(string));

            _requestPartsDataTable.Columns.Add("ID", typeof(int));
            _requestPartsDataTable.Columns.Add("Name", typeof(string));
            _requestPartsDataTable.Columns.Add("Amount", typeof (int));
            _requestPartsDataTable.Columns.Add("Prize", typeof(string));
        }

        public void UpdateAllPartsRows(IEnumerable<Part> allParts)
        {
            foreach (var part in allParts)
            {
                DataRow newRow = _allPartsDataTable.NewRow();

                newRow["ID"] = part.ID;
                newRow["Name"] = part.Name;
                newRow["Prize"] = part.Prize;

                _allPartsDataTable.Rows.Add(newRow);
            }
        }

        public DataTable GetAllPartsDataTable()
        {
            return _allPartsDataTable;
        }

        public void UpdateRequestPartsRows(IEnumerable<Part> requestParts)
        {
            foreach (var part in requestParts)
            {
                DataRow newRow = _requestPartsDataTable.NewRow();

                newRow["ID"] = part.ID;
                newRow["Name"] = part.Name;
                newRow["Amount"] = part.Amount;
                newRow["Prize"] = part.Prize;

                _requestPartsDataTable.Rows.Add(newRow);
            }
        }

        public DataTable GetRequestPartsDataTable()
        {
            return _requestPartsDataTable;
        }
    }
}
