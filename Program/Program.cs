using Program.one;
using Program.three;
using Program.two;
using Program.four;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 1 exercise
            /*Color color = new Color();
            color.Method(12, "wow");

            NewColor newColor = new NewColor();
            newColor.Method(12, "pop");*/
            #endregion

            #region 2 exercise
            /*C Cobj = new C(1, 2);
            D Dobj = new D(2, 3);
            E Eobj = new E(4, 5);

            A obj = new A(Cobj, Dobj, Eobj);
            obj.Bobject.Sum();
            obj.Bobject1.Sum();
            obj.Bobject2.Sum();*/
            #endregion

            #region 3 exercise
            /*First first = new First("Alex", 15);
            first.Print();
            Console.WriteLine();

            Second second = new Second("Max", "Kyiv");
            second.Print();
            Console.WriteLine();

            Third third = new Third("Roman", "Kopienko");
            third.Print();
            Console.WriteLine();*/
            #endregion

            #region 4 exercise

            ApplicationLicense applicationLicense = new ApplicationLicense();
            applicationLicense.Main();

            #endregion
        }
    }
}
