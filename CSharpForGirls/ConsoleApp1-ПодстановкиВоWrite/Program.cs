using System;

namespace ConsoleApp1_ПодстановкиВоWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Урок 'Использование {0} во Write'. Практика.");
            Console.WriteLine();

            /* Не менять ничего выше этой строки */
            /*************************************/

            string areaname;
            int amount;
            int total;
            double percent;

            areaname = "Д13";
            amount = 7;
            total = 1035;
            percent = 2;

            Console.Write("На участке ");
            Console.Write(areaname);
            Console.Write(" засохло ");
            Console.Write(amount);
            Console.Write(" деревьев из ");
            Console.Write(total);
            Console.Write(", что составляет ");
            Console.Write(percent);
            Console.Write("% от общего числа сушняка.");
            Console.WriteLine();

            Console.Write("На участке {0} засохло {1} деревьев из {2}, что составляет {3}% от общего числа сушняка.", areaname, amount, total, percent);
            Console.WriteLine();

            /*************************************/
            /* Не менять ничего ниже этой строки */
            Console.ReadLine();
        }
    }
}
