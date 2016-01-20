namespace WorkshopManager.Models.IRequest
{
    public interface IRequestWithIdAcces : IRequest
    {
        void SetId(int id);
    }
}