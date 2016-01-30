using System;
using System.Collections.Generic;
using System.Data;
using WorkshopManager.DatabasePresenter;

namespace WorkshopManager.Forms.RequestsDatabaseView
{
    public class RequestsDatabasePresenter
    {
        private IRequestsDatabaseView _view;
        private IRequestDatabaseAdapter _dataBase;

        public RequestsDatabasePresenter(IRequestsDatabaseView view)
        {
            _view = view;
            _view.Presenter = this;
            _dataBase = new DatabasePresenter.DatabasePresenter();

            Init();
        }

        public void Init()
        {
            SetActiveComboBoxDataSource();
            LoadRequestDataToDataGridView();
        }

        private void LoadRequestDataToDataGridView()
        {
            RequestsDataTableCreator dtCreator = new RequestsDataTableCreator();

            List<Request> requests = _dataBase.GetAll();
            dtCreator.UpdateRows(requests);

            DataTable currentDataTable = dtCreator.GetCurrentDataTable();
            _view.DataGridViewSource = currentDataTable;
        }

        public void OpenModifierFormForAdding()
        {
            //TODO musi wyciagac z comboBoxa aktualnie wybrana kategorie. Na razie roboczo zostawiono Active
            var requestsModifierForm = new RequestsModifierView.RequestsModifierView(RequestsCategory.Active);
            requestsModifierForm.ShowDialog();

            LoadRequestDataToDataGridView();
        }

        public void OpenModifierFormForEditing()
        {
            Request selectedRequest = GetSelectedRequest();
            var requestsModifierForm = new RequestsModifierView.RequestsModifierView(selectedRequest);
            requestsModifierForm.ShowDialog();
        }

        public void OnGeneratePDF()
        {

            //TODO rzuca exceptionem.
            PDFGenerator pdfGenerator = new PDFGenerator();

            Request selectedRequest = GetSelectedRequest();
            pdfGenerator.PDFGenerate(selectedRequest);
        }

        private Request GetSelectedRequest()
        {
            int selectedRequestId = (int) _view.SelectedRow.Cells[0].Value;
            
            return _dataBase.GetById(selectedRequestId);
        }

        public void OnDeleteSelectedRequest()
        {
            Request requestToDelete = GetSelectedRequest();
            _dataBase.DeleteById(requestToDelete.ID);
            LoadRequestDataToDataGridView();
        }

        private void SetActiveComboBoxDataSource()
        {
            _view.ActiveDataComboBox = Enum.GetValues(typeof(RequestsCategory));
        }
    }
}
