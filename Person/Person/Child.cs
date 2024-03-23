using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    internal class Child:Person
    {
        public Child(string name, int age):base(age,name)
        {
            
        }
        public int Age { get { return this.Age; } set { if (this.Age < 16) { this.Age = value; } } }
    }
}
