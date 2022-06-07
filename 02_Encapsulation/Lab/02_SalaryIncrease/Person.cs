using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { 
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                this.age = value; }
        }

        public decimal Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.age < 30)
            {
                percentage /= 2;
            }

            this.salary += this.salary * percentage /100;
        }
        public override string ToString()
        {            
            return $"{this.firstName} {this.lastName} receives {this.salary:F2} leva.";                      
        }
    }
}
