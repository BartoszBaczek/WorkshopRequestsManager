using System.Collections.Generic;
using WorkshopManager.Forms.ToolsForRequestVIew;

namespace WorkshopManager.Forms.RequestsModifierView
{
    public class RequestAdderPresenter : RequestsModifierPresenter
    {
        private Request requestToAdd;

        public RequestAdderPresenter(IRequestsModifierView view) : base(view)
        {
            Init();
        }

        public void Init()
        {
            requestToAdd = new Request("-", "-", "-", "-", new List<Part>(), false);
        }

        public override void OnAddRequesButtonClicked()
        {
            BuildRequestFromTextBoxesData();

            _dataBase.AddToDatabase(ref requestToAdd);

            _view.CloseForm();
        }

        public override void OnCancelButtonClicked()
        {
            _view.CloseForm();
        }

        public override void OnToolsForRequestButtonClicked()
        {
            BuildRequestFromTextBoxesData();

            var toolsForRequestForm = new ToolsForRequestView.ToolsForRequestView();
            toolsForRequestForm.ShowDialog();
        }

        private void BuildRequestFromTextBoxesData()
        {
            RequestUnderModification.Value.Model = _view.CarMarkTextBox;
            RequestUnderModification.Value.Owner = _view.OwnerTextBox;
            RequestUnderModification.Value.Mark = _view.CarMarkTextBox;
            RequestUnderModification.Value.Description = _view.DescriptionTextBox;
        }
    }
}
