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
                                             _view.CarMarkTextBox,
                                             _view.DescriptionTextBox,
                                             new List<Part>(),true); //uwaga nalezy poprawic bo dodalem byle co
            
            _dataBase.AddToDatabase(ref newRequest);

            _view.CloseForm();
        }

        public override void OnCancelButtonClicked()
        {
            _view.CloseForm();
        }

        public override void OnToolsForRequestButtonClicked()
        {
            var toolsForRequestForm = new ToolsForRequestView.ToolsForRequestView();
            toolsForRequestForm.ShowDialog();
        }
    }
}
