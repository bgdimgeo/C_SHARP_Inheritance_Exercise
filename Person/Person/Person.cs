using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int age;
        private string name;
        public Person(int age, string name)
        {
            Age = age;
            Name = name;

        }

        public int Age { get { return this.age; } set { if (value > 0) { this.age = value; } } }
        public string Name { get { return this.name; } set { if (value != null) { this.name = value; } } }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();
        }

    }
}
