using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;
        
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.name = value;
            }
        }
        public int Age {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }
        public virtual string Gender {
            get { return this.gender; }
            set 
            { 
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.gender = value; }
        }

        public virtual string Sound { get => null;}

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string ProduceSound()
        {
            return this.Sound;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.GetType().Name}\n{this.Name} {this.Age} {this.Gender}\n{ProduceSound()}");
            return sb.ToString();
        }   
    }
}
