using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager
{
    class Part
    {
        private int id;
        private string name;
        private double prize;

        Part()
        {
            name = "noname";
            prize = '0';
        }

        Part(int _id, string _name, double _prize)
        {
            name = _name;
            prize = _prize;

        }
    }
}
