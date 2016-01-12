namespace WorkshopManager.Forms.RequestsModifierView
{
    public class RequestEditorPresenter : RequestsModifierPresenter
    {
        public RequestEditorPresenter(IRequestsModifierView view) : base(view)
        {
            Init();
        }

        public void Init()
        {
            _view.RequestId = "tysiacPiecsietStoDziewiecset";
            _view.CarModelTextBox = "Do edycji";
            _view.OwnerTextBox = "Do edycji";
            _view.DescriptionTextBox = "Do edycji";
        }
    }
}
