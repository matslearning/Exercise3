using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Pelican : Bird
    {
        public string BeakColor { get; set; }
        public Pelican(string name, double weight, int age, int wingspan, string beakColor) : base(name, weight, age, wingspan)
        {
            BeakColor = beakColor;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bäärk!");
        }

        public override string Stats()
        {
            return base.Stats() + $", BeakColor: {BeakColor}";
        }
    }
}
