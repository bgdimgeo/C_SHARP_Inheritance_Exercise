using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Cat:Animal
    {
        public Cat():base()
        {

        }
        public void Meow() 
        {
            Console.WriteLine("meowing…");
        }
    }
}
