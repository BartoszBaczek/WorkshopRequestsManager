using WorkshopManager.DatabasePresenter;

namespace WorkshopManager.Forms.RequestsModifierView
{
    public abstract class RequestsModifierPresenter
    {
        protected IRequestsModifierView _view;
        protected IRequestDatabaseAdapter _dataBase;

        protected RequestsModifierPresenter(IRequestsModifierView view)
        {
            _view = view;
            _view.Presenter = this;
            _dataBase = new DatabasePresenter.DatabasePresenter();
        }

        public abstract void OnAddRequesButtonClicked();
        public abstract void OnCancelButtonClicked();
    }
}
