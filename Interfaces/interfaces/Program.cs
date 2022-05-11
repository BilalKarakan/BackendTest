using System;

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
            interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer:IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

            string Address { get; set; }
        }
        class Student:IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

            string Department { get; set; }
        }
        
    }
}
