using System;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            intro();
            intro2();
            Console.ReadLine();
        }

        private static void intro2()
        {
            string sentence = "The weather is very cold today.";
            Console.WriteLine(sentence.Length);
            var result = sentence.Clone();
            //sentence = "The weather will be very cold tomorrow.";
            Console.WriteLine(result);

            Console.WriteLine(sentence.StartsWith("T")); // bool
            Console.WriteLine(sentence.EndsWith("."));  // bool

            Console.WriteLine(sentence.IndexOf("very"));
            Console.WriteLine(sentence.IndexOf("veryy"));
            Console.WriteLine(sentence.IndexOf(" "));
            Console.WriteLine(sentence.LastIndexOf(" "));
            Console.WriteLine(sentence.Insert(0, "Hello, "));
            Console.WriteLine(sentence.Substring(4));
            Console.WriteLine(sentence.Substring(4, 10));
            Console.WriteLine(sentence.ToLower());
            Console.WriteLine(sentence.ToUpper());
            Console.WriteLine(sentence.Replace(" ", " * "));
            Console.WriteLine(sentence.Remove(3));
            Console.WriteLine(sentence.Remove(3, 11));
        }

        private static void intro()
        {
            string city = "Ankara";
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            string result = city + " " + city2;
            Console.WriteLine("{0} {1}", city, city2);
            Console.WriteLine(result);
        }
    }
}
