

using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    internal class RandomList:List<string>
    {
        public RandomList():base()
        {

        }
        public string RandomString() 
        {
            string newString = string.Empty;
            if (this.Count > 0) 
            {
                Random rnd = new Random();
                int num = rnd.Next();
                newString = this[num];
                this.RemoveAt(num);
            }
            return newString;
        }
    }
}
