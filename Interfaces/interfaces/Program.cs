using System;

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalManager manager = new PersonalManager();
            Customer customer = new Customer { Id=1, FirstName="Bilal", LastName="Karakan", Address="İstanbul"};
            manager.Add(customer);
            //manager.Add(new Customer { id=1, FirstName="Bilal", LastName="Karakan", Address="İstanbul"});
            //The usage on lines 10 and 11 is the same as on line 12.

            Student student = new Student
            {
                Id = 2,
                FirstName = "Steve",
                LastName = "Jobs",
                Department = "Apple"
            };
            manager.Add(student);
            manager.Add(new Worker { Id= 3, FirstName="Bill", LastName="Gates", Department="Microsoft" });

            Console.ReadLine();

        }
            interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Department { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Department { get; set; }
        }
        class PersonalManager
        {
            //public void Add(Customer customer)
            //{
            //    Console.WriteLine(customer.FirstName);
            //}
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
        
    }
}
