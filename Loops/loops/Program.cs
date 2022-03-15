using System;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //forLoop();
            //whileLoop();
            //doWhileLoop();
            //foreachLoop();
            //primeNumber();

            private static void foreachLoop()
            {
                string[] students = new string[] { "Bilal", "Elif", "Beyza" };
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }

                Console.WriteLine("***************");

                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine(students[i]);
                }
            }

            private static void doWhileLoop()
            {
                int n = 10;
                do
                {
                    Console.WriteLine(n);
                    n--;
                } while (n > 11);
            }

            private static void whileLoop()
            {
                int j = 100;
                while (j >= 1)
                {
                    Console.Write("{0,5}", j);
                    j -= 2;
                }
                Console.WriteLine("\nNow j is {0}", j);
            }

            private static void forLoop()
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.Write("{0,3}", i);
                }

                //******************************************

                for (int i = 1; i <= 100; i += 2)
                {
                    Console.Write("{0,3}", i);
                }

                //******************************************

                for (int i = 100; i >= 1; i -= 2)
                {
                    Console.Write("{0,5}", i);
                }
            }

            int number = Convert.ToInt32(Console.ReadLine());
                bool isPrime = true;
                if (number == 1)
                {
                    isPrime = false;
                }
                if (number <= 0)
                {
                    Console.WriteLine("Invalid Number!");
                    return;
                }
                {

                }

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false; break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("{0} is a prime number", number);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number", number);
                }
            

            
            Console.ReadLine();
        }

       
    }
}
