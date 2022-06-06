using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender) { }

        public string CatSound = "Meow meow";

        public override string Sound => this.CatSound;
    }
}
