using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int age;
        private string name;
        public int Age 
        { 
            get { return this.age; }
            protected set { 
                if (value < 0)
                {
                    throw new ArgumentException("The person's age cannot be negative");
                }
                this.age = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Person(string name, int age)
        {            
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return sb.ToString();
        }

    }
}
