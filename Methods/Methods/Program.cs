using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            /*var result = Add2(30, 40);
            var result2 = Add3(20);
            int number1 = 20;
            int number2 = 100;
            var result3 = Add4(ref number1, number2); // ref ile değer tipleri referans tiplere dönüştürebiliriz.
            Console.WriteLine(result3);
            Console.WriteLine(number1); // 30 çıktısı gelir.
            Console.WriteLine(result);*/
            Console.WriteLine(Multiply(2, 4, 6));
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Add5(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.ReadLine();
            // ref keyword yerine out da gönderebiliriz. Aralarındaki fark ise ref keyword kullanıcaksak değişkenlere değer atamak zorundayız.
            // Out keyword böyle bir zorunluluk yoktur.
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }
        static int Add3(int number1, int number2 = 10)
        {
            return number1 + number2;
        }
        static int Add4(ref int number1, int number2) { 
            number1 = 30;
            return number1 + number2;
        }

        //Method Overloading
        static int Multiply(int number1 , int number2) { 
            return number1 * number2;
        }
        static int Multiply(int number1 , int number2, int number3) { 
            return number1 * number2 * number3;
        }

        //Params

        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    
    
    
    
    }   
}
