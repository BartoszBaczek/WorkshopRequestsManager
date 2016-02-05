using System.Collections.Generic;
using WorkshopManager.Forms.ToolsForRequestVIew;
using WorkshopManager.Models.IRequest;

namespace WorkshopManager.Forms.RequestsModifierView
{
    public class RequestEditorPresenter : RequestsModifierPresenter
    {
        public RequestEditorPresenter(IRequestsModifierView view, object requestToModify) : base(view)
        {
            RequestUnderModification.Value = requestToModify as Request;
            RequestUnderModification.Value.ListOfParts = (requestToModify as Request).ListOfParts;
            Init();
        }

        public void Init()
        {
            _view.CarModelTextBox = RequestUnderModification.Value.Model;
            _view.CarMarkTextBox = RequestUnderModification.Value.Mark;
            _view.OwnerTextBox = RequestUnderModification.Value.Owner;
            _view.DescriptionTextBox = RequestUnderModification.Value.Description;
        }

        public override void OnAddRequesButtonClicked()
        {
            BuildRequestFromTextBoxesData();

            _dataBase.UpdateRequest(RequestUnderModification.Value);
            _view.CloseForm();
        }

        public override void OnCancelButtonClicked()
        {
            _view.CloseForm();
        }

        private void BuildRequestFromTextBoxesData()
        {
            RequestUnderModification.Value.Model = _view.CarMarkTextBox;
            RequestUnderModification.Value.Owner = _view.OwnerTextBox;
            RequestUnderModification.Value.Mark = _view.CarMarkTextBox;
            RequestUnderModification.Value.Description = _view.DescriptionTextBox;
        }
        
        public override void OnToolsForRequestButtonClicked()
        {
            var toolsForRequestForm = new ToolsForRequestView.ToolsForRequestView();
            toolsForRequestForm.ShowDialog();
        }
    }
}
