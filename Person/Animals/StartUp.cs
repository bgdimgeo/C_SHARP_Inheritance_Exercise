using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "Beast!") 
            {
                string input2 = Console.ReadLine();
                string[] inputArgs = input2.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = inputArgs[0];
                int age = int.Parse(inputArgs[1]);
                string gender = inputArgs[2];
                if (name == null) 
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                if (age < 0 )
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                if (gender == null)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                if (input == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    Console.WriteLine(dog.ToString());
                }
                else if (input == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    Console.WriteLine(frog.ToString());
                }
                else if (input == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                   
                }
                else if (input == "Tomcat") 
                {
                    Tomcat tomcat = new Tomcat(name, age, gender);
                    Console.WriteLine(tomcat.ToString());
                }
                else if (input == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age, gender);
                    Console.WriteLine(kitten.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                input = Console.ReadLine();
            }
        }
    }
}
