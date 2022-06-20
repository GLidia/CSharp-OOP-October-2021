using System;
using System.Collections.Generic;
using System.Text;

namespace _07_CustomException
{
    public class Student
    {
        private string name;
        private string email;

        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { 
            get => name;
            set
            {
                foreach (Char symbol in value)
                {
                    if (!Char.IsLetter(symbol))
                    {
                        throw new InvalidPersonNameException("The name can only contain letters.");
                    }
                }
                this.name = value;
            }
        }
        public string Email { get => email; set => email = value; }
    }
}
