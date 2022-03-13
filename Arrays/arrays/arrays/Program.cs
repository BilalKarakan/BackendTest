using System;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] students = new string[3];
            students[0] = "Bilal";
            students[1] = "Elif";
            students[2] = "Beyza";

            string[] students2 = new[] { "Bilal", "Elif", "Beyza" };

            string[] students3 = { "Bilal", "Elif", "Beyza" };

            string[] students4 = new string[3] {"Bilal", "Elif", "Beyza"};

            foreach (var student in students4)
            {
                Console.WriteLine(student);
            }
            


            string[,] regions = new string[7,3]
            {
                {"İstanbul", "Bursa", "Kocaeli"},
                {"İzmir", "Manisa", "Aydın"},
                {"Antalya", "Mersin", "Adana"},
                {"Ankara", "Konya", "Niğde"},
                {"Rize", "Ordu", "Samsun"},
                {"Erzurum", "Erzincan", "Elazığ"},
                {"Şanlıurfa", "Şırnak", "Gaziantep"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                if (i==6)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("*******************");
                }

            }
            Console.ReadLine();

        }
    }
}
