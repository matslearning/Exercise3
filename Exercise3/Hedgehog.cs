using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercise3
{
    class Hedgehog : Animal
    {
        public bool IsCurledUp { get; set; }
        public Hedgehog(string name, double weight, int age, bool isCurledUp) : base(name, weight, age)
        {
            IsCurledUp = isCurledUp;
        }

        public override void DoSound()
        {
            Console.WriteLine("Frsh!");
        }

        public override string Stats()
        {
            return base.Stats() + $", IsCurledUp: {IsCurledUp}";
        }
    }
}
