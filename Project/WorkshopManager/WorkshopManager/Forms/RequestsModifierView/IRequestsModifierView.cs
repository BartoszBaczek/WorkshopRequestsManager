namespace WorkshopManager.Forms.RequestsModifierView
{
    public interface IRequestsModifierView
    {
        RequestsCategory RequestCategory { get; }
        RequestsModifierPresenter Presenter { set; }

        string OwnerTextBox { get; set; }
        string CarModelTextBox { get; set; }
        string CarMarkTextBox { get; set; }
        string DescriptionTextBox { get; set; }

        void CloseForm();
    }
}
