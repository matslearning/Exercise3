using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Swan : Bird
    {
        public string HomePond { get; set; }
        public Swan(string name, double weight, int age, int wingspan, string homePond) : base(name, weight, age, wingspan)
        {
            HomePond = homePond;
        }

        public override void DoSound()
        {
            Console.WriteLine("Gwerekk!");
        }

        public override string Stats()
        {
            return base.Stats() + $", HomePond: {HomePond}";
        }
    }
}
