namespace WorkshopManager
{
    public class Part
    {
        public int ID { get; private set; }     //Musze miec do tego dostep, ale nie bede mogl tego zmieniac, jak juz raz zostanie ustalone
        public string Name { get; set; }
        public double Prize { get; set; }

        public Part(int id, string name, double prize)
        {
            ID = id;
            Name = name;
            Prize = prize;
        }

        public bool Equals(Part part)
        {
            return false;
        }
    }
}
