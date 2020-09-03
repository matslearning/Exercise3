using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Flamingo : Bird
    {
        public double LegLength { get; set; }
        public Flamingo(string name, double weight, int age, int wingspan, double legLength) : base(name, weight, age, wingspan)
        {
            LegLength = legLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("Krö-krö-krö!");
        }
        public override string Stats()
        {
            return base.Stats() + $", LegLength: {LegLength}";
        }
    }
}
