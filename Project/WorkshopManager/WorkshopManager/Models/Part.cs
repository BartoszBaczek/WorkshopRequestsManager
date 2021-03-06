﻿using WorkshopManager.IPart;

namespace WorkshopManager
{
    public class Part : IPartWithIdAcces
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public double Prize { get; set; }
        public int Amount { get; set; }


        public Part(string name, double prize, int amount )
        {
            Name = name;
            Prize = prize;
            Amount = amount;
        }

        public Part(string name, double prize)
        {
            Name = name;
            Prize = prize;

        }

        public bool Equals(Part part)
        {
            return (Name == part.Name && Prize == part.Prize);
        }

        public void SetId(int id)
        {
            ID = id;
        }
    }
}
