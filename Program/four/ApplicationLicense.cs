using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.four
{
    internal class ApplicationLicense
    {
        public int TrialKey { get; set; } = 11111;
        public int ProKey { get; set; } = 12345;
       

        public void Main()
        {
            int key;
            int num;
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("             Меню");
                Console.WriteLine("1. Ввести iснуючий trial ключ");
                Console.WriteLine("2. Ввести iснуючий pro ключ");
                Console.WriteLine("3. Отримати безкоштовний ключ");
                Console.WriteLine("         0. Вихiд");
                Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
                Console.Write("Введiть цифру для виконання операцiї: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (num)
                {
                    case 1:
                        Console.Write("Введіть trial ключ: ");
                        key = Convert.ToInt32(Console.ReadLine());
                        if (key == TrialKey)
                        {
                            bool ex = true;
                            int tmp;
                            while (ex)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                AllowTrial();
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.WriteLine("     Меню");
                                Console.WriteLine("1. Дiя перша ");
                                Console.WriteLine("2. Дiя друга");
                                Console.WriteLine("   0. Вихiд");
                                Console.WriteLine("_-_-_-_-_-_-_-_-_");
                                Console.Write("Введiть цифру для виконання операцiї: ");
                                tmp = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();

                                if (tmp == 0) ex = false;
                            }
                        }
                        else
                            Console.WriteLine("Ключ не вiрний");
                        break;

                    case 2:
                        Console.Write("Введiть pro ключ: ");
                        key = Convert.ToInt32(Console.ReadLine());
                        if (key == ProKey)
                        {
                            bool ex = true;
                            int tmp;
                            while (ex)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                AllowPro();
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.WriteLine("     Меню");
                                Console.WriteLine("1. Дiя перша ");
                                Console.WriteLine("2. Дiя друга");
                                Console.WriteLine("   0. Вихiд");
                                Console.WriteLine("_-_-_-_-_-_-_-_-_");
                                Console.Write("Введiть цифру для виконання операцiї: ");
                                tmp = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();

                                if (tmp == 0) ex = false;
                            }
                        }
                        else
                            Console.WriteLine("Ключ не вiрний");
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        AllowCommond();
                        Console.ResetColor();
                        Console.WriteLine();
                        break;

                    case 0:
                        exit = false;
                        break;

                    default:
                        break;
                }
            }

        }
        public void AllowTrial()
        {
            Console.WriteLine("Триальний режим");
        }

        public void AllowCommond()
        {
            Console.WriteLine("Безкоштовна версiя");
        }

        public void AllowPro()
        {
            Console.WriteLine("Платна версiя");
        }
    }
}
