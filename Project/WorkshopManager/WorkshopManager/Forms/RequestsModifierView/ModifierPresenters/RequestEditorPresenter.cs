using System.Collections.Generic;
using WorkshopManager.Models.IRequest;

namespace WorkshopManager.Forms.RequestsModifierView
{
    public class RequestEditorPresenter : RequestsModifierPresenter
    {
        private Request _requestToModify;

        public RequestEditorPresenter(IRequestsModifierView view, object requestToModify) : base(view)
        {
            _requestToModify = requestToModify as Request;
            Init();
        }

        public void Init()
        {
            _view.CarModelTextBox = _requestToModify.Model;
            _view.CarMarkTextBox = _requestToModify.Mark;
            _view.OwnerTextBox = _requestToModify.Owner;
            _view.DescriptionTextBox = _requestToModify.Description;
        }

        public override void OnAddRequesButtonClicked()
        {
            _requestToModify.Model = _view.CarModelTextBox;
            _requestToModify.Mark = _view.CarMarkTextBox;
            _requestToModify.Owner = _view.OwnerTextBox;
            _requestToModify.Description = _view.DescriptionTextBox;

            _dataBase.UpdateRequest(_requestToModify);
            _view.CloseForm();
        }

        public override void OnCancelButtonClicked()
        {
            _view.CloseForm();
        }
    }
}
