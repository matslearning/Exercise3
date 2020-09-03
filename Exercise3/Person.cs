using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Ålder måste vara större än noll!");
                }
                age = value; 
            }
        }
        public string FName
        {
            get { return fName; }
            set 
            {
                var len = value.Length;
                if (len < 2 || len > 10)
                {
                    throw new ArgumentException($"Förnamnet måste vara mellan 2 och 10 tecken långt!");
                }
                fName = value; 
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                var len = value.Length;
                if (len < 3 || len > 15)
                {
                    throw new ArgumentException($"Efternamnet måste vara mellan 3 och 15 tecken långt!");
                }
                lName = value;
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }




    }
}
