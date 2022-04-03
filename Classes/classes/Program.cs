using System;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Updated();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Bilal";
            customer.LastName = "Karakan";
            customer.City = "İzmir";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Elif",
                LastName = "Durur",
                City = "İzmir"
            };

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.City);

            Console.ReadKey();
        }
    }
}
