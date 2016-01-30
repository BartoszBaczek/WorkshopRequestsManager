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
            _view.CarModelTextBox = "Do edycji";
            _view.CarMarkTextBox = "markachujowa";
            _view.OwnerTextBox = "Do edycji";
            _view.DescriptionTextBox = "Do edycji";
        }

        public override void OnAddRequesButtonClicked()
        {
            
        }

        public override void OnCancelButtonClicked()
        {
            throw new System.NotImplementedException();
        }
    }
}
