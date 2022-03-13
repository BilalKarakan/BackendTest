using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            //if (number < 10)
            //{
            //    Console.WriteLine("Number is less than 10");
            //}
            //else if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else
            //{
            //    Console.WriteLine("Number is great than 10");
            //}


            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("number is between 101-200");
            }
            else if (number < 0 && number > 200)
            {
                Console.WriteLine("number is less than 0 or great than 200");
            }

            Console.ReadLine();

        }
    }
}
