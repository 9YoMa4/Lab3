using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.two
{
    public class E:B
    {
        public E(int a, int b) : base(a, b)
        {

        }
        public override void Sum()
        {
            Console.WriteLine("class E");


            Console.WriteLine("Don`t work, try next time");
            Console.WriteLine();
        }
    }
}
