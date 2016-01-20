namespace WorkshopManager.IPart
{
    public interface IPart
    {
        int ID { get; }
        string Name { get; set; }
        double Prize { get; set; }
    }
}