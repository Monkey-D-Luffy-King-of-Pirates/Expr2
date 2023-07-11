using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Please, enter any three - digit number: ");

            while (!int.TryParse(Console.ReadLine(), out number) && !(number > 100 && number < 999))

            {
                Console.Write("No, you wrong! Please, enter any three - digit number: ");
            }

            int x = number % 10;
            int y = number / 10 % 10;
            int z = number / 100;

            Console.WriteLine(x * 100 + y * 10 + z);

            Console.ReadKey();
        }
    }
}
