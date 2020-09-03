using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Worm : Animal
    {
        public bool IsFishBait { get; set; }
        public Worm(string name, double weight, int age, bool isFishBait) : base(name, weight, age)
        {
            IsFishBait = isFishBait;
        }

        public override void DoSound()
        {
            Console.WriteLine("Mrbh...");
        }
        public override string Stats()
        {
            return base.Stats() + $", IsFishBait: {IsFishBait}";
        }
    }
}
