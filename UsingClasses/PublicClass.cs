using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClasses
{
    internal class DemoClass
    {
        private string thing;
        private int number;
        public DemoClass(string thing, int number)
        {
            this.thing = thing;
            this.number = number;
        }
        public void Print()
        {
            Console.WriteLine($"Thing: {thing}, Number: {number}");
        }
        public int GetNumber()
        {
            return number;
        }
    }

}
