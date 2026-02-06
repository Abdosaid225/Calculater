using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;
            string answar;
            Console.WriteLine("hallo, Welocme to the culculator program");
            Console.WriteLine("please Enter your first Name.");

            num1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please Enter your second Number.");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's type of operation wolud you like to do");
            Console.WriteLine("please Enter a for addition, s for substraction,m for multplication or any other key for division");

            answar = Console.ReadLine();

            if (answar == "a")
            {
                result = num1 + num2;
            }
            else if (answar == "s") 
            {
                 result = num1 - num2;
            }else if (answar == "m")
            {
                result = num1 * num2;
            } else
            {
                result = num1 / num2;
            }

            Console.WriteLine("the result is " + result);
            Console.WriteLine("thanks youu for using the calculater program! ");

            Console.ReadLine();
        }
    }
}
