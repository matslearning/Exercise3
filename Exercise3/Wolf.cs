using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Wolf : Animal
    {
        public bool BelongsToPack { get; set; }
        public Wolf(string name, double weight, int age, bool belongsToPack) : base(name, weight, age)
        {
            BelongsToPack = belongsToPack;
        }

        public override void DoSound()
        {
            Console.WriteLine("Yyl!");
        }

        public override string Stats()
        {
            return base.Stats() + $", BelongsToPack: {BelongsToPack}";
        }
    }
}
