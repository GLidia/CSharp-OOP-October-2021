using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {

        public Kitten(string name, int age) : base(name, age, KittenGender) { }
        public Kitten(string name, int age, string gender) : base(name, age, KittenGender) { }

        public string KittenSound = "Meow";

        public override string Sound => this.KittenSound;

        public const string KittenGender = "Female";
    }
}
