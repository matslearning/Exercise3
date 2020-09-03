using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Horse : Animal
    {
        public bool IsWild { get; set; }
        public Horse(string name, double weight, int age, bool isWild) : base(name, weight, age)
        {
            IsWild = isWild;
        }

        public override void DoSound()
        {
            Console.WriteLine("Gnägg!");
        }

        public override string Stats()
        {
            return base.Stats() + $", IsWild: {IsWild}";
        }
    }
}
