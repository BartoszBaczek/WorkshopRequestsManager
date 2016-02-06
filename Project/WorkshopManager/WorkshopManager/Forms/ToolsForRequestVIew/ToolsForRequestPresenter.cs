using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WorkshopManager.DatabasePresenter;
using WorkshopManager.Forms.ToolsForRequestVIew;

namespace WorkshopManager.Forms.ToolsForRequestView
{
    public class ToolsForRequestPresenter
    {
        private IToolsForRequestView _view;
        private IPartsDatabaseAdapter _dataBase;

        public ToolsForRequestPresenter(IToolsForRequestView view)
        {
            _view = view;
            _view.Presenter = this;

            _dataBase = new DatabasePresenter.DatabasePresenter();
            Init();
        }

        private void Init()
        {
            LoadAllPartsDataToDataGridView();
            LoadRequestpartsDataToDataGridView();
        }

        private void LoadAllPartsDataToDataGridView()
        {
            ToolsForRequestDataTableCreator dtCreator = new ToolsForRequestDataTableCreator();

            List<Part> allParts = _dataBase.GetAll();
            dtCreator.UpdateAllPartsRows(allParts);

            DataTable allPartsDataTable = dtCreator.GetAllPartsDataTable();
            _view.AllPartsDataGridViewSource = allPartsDataTable;
        }

        private void LoadRequestpartsDataToDataGridView()
        {
            ToolsForRequestDataTableCreator dtCreator = new ToolsForRequestDataTableCreator();

            List<Part> requestParts = RequestUnderModification.Value.ListOfParts;
            dtCreator.UpdateRequestPartsRows(requestParts);
            
            DataTable requestPartsDataTable = dtCreator.GetRequestPartsDataTable();
            _view.RequestPartsDataGridViewSource = requestPartsDataTable;
        }

        private Part GetSelectedFromAllParts()
        {
            int selectedFromAllPartsID = (int) _view.AllPartsSelectedRow.Cells[0].Value;
            return _dataBase.GetById(selectedFromAllPartsID);
        }

        private Part GetSelectedFromRequestParts()
        {
            if (_view.RequestPartsSelectedRow == null)
                return null;

            int selectedFromAllPartsID = (int)_view.RequestPartsSelectedRow.Cells[0].Value;
                return _dataBase.GetById(selectedFromAllPartsID);
        }

        public void OnMoveToRequestButtonClicked()
        {
            Part selectedPart = GetSelectedFromAllParts();
            if (RequestUnderModification.Value.ListOfParts.Any(p => p.ID == selectedPart.ID))
                for (int i = 0; i < _view.QuantityOfPartsToMoveAtOnce; i++)
                    RequestUnderModification.Value.ListOfParts.First(p => p.ID == selectedPart.ID).Amount++;
            else
            {
                RequestUnderModification.Value.ListOfParts.Add(selectedPart);
                RequestUnderModification.Value.ListOfParts.First(p => p.ID == selectedPart.ID).Amount++;

                for (int i = 0; i < _view.QuantityOfPartsToMoveAtOnce - 1; i++)
                    RequestUnderModification.Value.ListOfParts.First(p => p.ID == selectedPart.ID).Amount++;
            }

            LoadRequestpartsDataToDataGridView();
        }

        public void OnDeleteFromRequestButtonClicked()
        {
            Part selectedPart = GetSelectedFromRequestParts();
            RequestUnderModification.Value.ListOfParts.RemoveAll(p => p.ID == selectedPart.ID);

            LoadRequestpartsDataToDataGridView();
        }


    }
}
