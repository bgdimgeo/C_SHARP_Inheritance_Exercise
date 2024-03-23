using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake:Dessert
    {
        private const decimal cakePrice = 5m;
        public Cake(string name, double grams, double calories) : base(name, cakePrice, grams, calories)
        {
            Grams = 250;
            Calories = 1000;
            Price = cakePrice;
        }
        
    }

}
