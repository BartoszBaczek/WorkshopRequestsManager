namespace WorkshopManager.Forms.RequestsModifierView
{
    public interface IRequestsModifierView
    {
        RequestsCategory RequestCategory { get; }
        RequestsModifierPresenter Presenter { set; }

        string RequestId { get; set; }
        string OwnerTextBox { get; set; }
        string CarModelTextBox { get; set; }
        string DescriptionTextBox { get; set; }

        void CloseForm();
    }
}
