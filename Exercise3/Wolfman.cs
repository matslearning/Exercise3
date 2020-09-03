using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, bool belongsToPack) : base(name, weight, age, belongsToPack)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("...Wolfman gör inga läten - Gammalt djungelordspråk");
        }

        public void Talk()
        {
            Console.WriteLine("Hello! I'm a Wolfman.");
        }

        public override string Stats()
        {
            return base.Stats();
        }
    }
}
