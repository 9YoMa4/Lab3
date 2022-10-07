using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.two
{
    public class D:B
    {
        public D(int a, int b) : base(a, b)
        {

        }
        public override void Sum()
        {
            Console.WriteLine("class D");

            Console.WriteLine($"A = {Aint} and B = {Bint}");
            base.Sum();
            Console.WriteLine();
        }
    }
}
