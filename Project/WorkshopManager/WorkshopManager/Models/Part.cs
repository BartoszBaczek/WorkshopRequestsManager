using WorkshopManager.IPart;

namespace WorkshopManager
{
    public class Part : IPartWithIdAcces
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public double Prize { get; set; }
        public double Amount { get; set; }


        public Part(string name, double prize)
        {
            Name = name;
            Prize = prize;
        }

        public bool Equals(Part part)
        {
            return false;
        }

        public void SetId(int id)
        {
            ID = id;
        }
    }
}
