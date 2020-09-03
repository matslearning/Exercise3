using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Exercise3
{
    class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            var pers = new Person()
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };

            return pers;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string fname)
        {
            pers.FName = fname;
        }
        public void SetLName(Person pers, string lname)
        {
            pers.LName = lname;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetAWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}
