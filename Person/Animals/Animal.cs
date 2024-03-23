using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        //name, an age, and a gender
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;

        }

        public string  Name { get { return this.name; } set { this.name = value; } }
        public string Gender { get { return this.gender; } set { this.gender = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }

        public abstract string ProduceSound();
        public override string ToString()
        {

            return $"{this.GetType().Name}" +
                   $"{Environment.NewLine}{Name} {Age} {Gender}"+
                   $"{Environment.NewLine}{ProduceSound()}";
        }

    }
}
