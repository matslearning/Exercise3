using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Dog : Animal
    {
        public string Color { get; set; }
        public Dog(string name, double weight, int age, string color) : base(name, weight, age)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Voff!");
        }

        public override string Stats()
        {
            return base.Stats() + $", Color: {Color}";
        }

        public string NewMethod()
        {
            return "Tjohopp!!";
        }
    }
}
