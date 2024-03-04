using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PizzaStore1
{
    public class Store
    {
         public void Start()
        {
            Pizza pizza1 = new Pizza("Margherita", 80);
            Pizza pizza2 = new Pizza("Vesuvio", 92);
            Pizza pizza3 = new Pizza("Capricciosa", 98);

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            Order order1 = new Order(pizza1, customer1);
            Order order2 = new Order(pizza2, customer2);
            Order order3 = new Order(pizza3, customer3);

            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);
        }
    }
}
