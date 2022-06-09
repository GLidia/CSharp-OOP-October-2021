using System;
using System.Collections.Generic;
using System.Text;

namespace _05_BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        public string Name { get; private set; }
        public string Birthdate { get; private set; }

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
    }
}
