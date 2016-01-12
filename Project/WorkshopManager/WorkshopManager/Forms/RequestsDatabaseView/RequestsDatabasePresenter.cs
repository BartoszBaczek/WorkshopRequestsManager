using System;

namespace WorkshopManager.Forms.RequestsDatabaseView
{
    public class RequestsDatabasePresenter
    {
        private IRequestsDatabaseView _view;

        public RequestsDatabasePresenter(IRequestsDatabaseView view)
        {
            _view = view;
            _view.Presenter = this;

            Init();
        }

        public void Init()
        {
            SetActiveComboBoxDataSource();
        }

        private void SetActiveComboBoxDataSource()
        {
            _view.ActiveDataComboBox = Enum.GetValues(typeof(RequestsCategory));
        }
    }
}
