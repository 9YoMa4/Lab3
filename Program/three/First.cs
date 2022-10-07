using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.three
{
    internal class First: Person
    {
        public First(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public void Print()
        {
            Console.WriteLine("First class");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
        }
    }
}
