using System.Collections.Generic;

namespace WorkshopManager.Forms.RequestsModifierView
{
    public class RequestAdderPresenter : RequestsModifierPresenter
    {
        public RequestAdderPresenter(IRequestsModifierView view) : base(view)
        {
            Init();
        }

        public void Init()
        {
            
        }

        public override void OnAddRequesButtonClicked()
        {
            Request newRequest = new Request(_view.CarModelTextBox,
                                             _view.OwnerTextBox,
                                             "marka ktora musze dodac do widoku",
                                             _view.DescriptionTextBox,
                                             new List<Part>());
            
            _dataBase.AddToDatabase(ref newRequest);

            _view.CloseForm();
        }

        public override void OnCancelButtonClicked()
        {
            _view.CloseForm();
        }
    }
}
