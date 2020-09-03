using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Bird : Animal
    {
        public int Wingspan { get; set; }
        public Bird(string name, double weight, int age, int wingspan) : base(name, weight, age)
        {
            Wingspan = wingspan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Pip!");
        }
        public override string Stats()
        {
            return base.Stats() + $", Wingspan: {Wingspan}";
        }
    }
}
