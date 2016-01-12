namespace WorkshopManager.Forms.RequestsModifierView
{
    public interface IRequestsModifierView
    {
        RequestsModifierPresenter Presenter { set; }

        string OwnerTextBox { get; set; }
        string CarModelTextBox { get; set; }
        string DescriptionTextBox { get; set; }
    }
}
