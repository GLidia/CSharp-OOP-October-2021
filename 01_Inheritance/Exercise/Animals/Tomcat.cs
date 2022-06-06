using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, TomcatGender) { }
        public Tomcat(string name, int age, string gender) : base(name, age, TomcatGender) { }
        

        public string TomcatSound = "MEOW";

        public override string Sound => this.TomcatSound;

        public const string TomcatGender = "Male";
    }
}
