using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.one
{
    public class NewColor: Color
    {
        public override void Method(int a, string b)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{a}, {b}");
            Console.ResetColor();
        }
    }
}
