using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings:Stack<string>
    {
        public StackOfStrings():base()
        {
            
        }

        public bool isEmpty()
        {
            bool returnValue = false;
            if (this.Count > 0) 
            {
                returnValue = true;
            }
            return returnValue;
        }
        public Stack<string> AddRange()
        {
            int nums = this.Count;
            if (nums > 0)
            {
                for (int i = 0; i < nums; i++)
                {
                    this.Push(string.Empty);
                }
            }
            else 
            {
                this.Push(string.Empty);
            }
            return this;


        }


    }
}
