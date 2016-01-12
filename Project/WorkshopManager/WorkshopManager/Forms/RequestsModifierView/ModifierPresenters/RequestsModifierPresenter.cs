namespace WorkshopManager.Forms.RequestsModifierView
{
    public abstract class RequestsModifierPresenter
    {
        protected IRequestsModifierView _view;

        protected RequestsModifierPresenter(IRequestsModifierView view)
        {
            _view = view;
            _view.Presenter = this;
        }
    }
}
