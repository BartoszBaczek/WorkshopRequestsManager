using System.Collections.Generic;
using System.Linq;
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

            deletedParts = deletedParts.Except(RequestUnderModification.Value.ListOfParts).ToList();

            foreach (var part in deletedParts)
            {
                _dataBase.DeletePart(RequestUnderModification.Value.ID, part.ID);
            }

            _view.CloseForm();
        }

        public override void OnCancelButtonClicked()
        {
            _view.CloseForm();
        }

        private void BuildRequestFromTextBoxesData()
        {
            RequestUnderModification.Value.Model = _view.CarModelTextBox;
            RequestUnderModification.Value.Owner = _view.OwnerTextBox;
            RequestUnderModification.Value.Mark = _view.CarMarkTextBox;
            RequestUnderModification.Value.Description = _view.DescriptionTextBox;
        }
        
        List<Part> deletedParts = new List<Part>(); 
        public override void OnToolsForRequestButtonClicked()
        {
            foreach (var part in RequestUnderModification.Value.ListOfParts)
            {
                deletedParts.Add(part);
            }

            var toolsForRequestForm = new ToolsForRequestView.ToolsForRequestView();
            toolsForRequestForm.ShowDialog();
        }
    }
}
