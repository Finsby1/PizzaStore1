using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore1
{
    public class Order
    {
        double _tax;
        double _deliveryCost;
        Pizza p;
        Customer c;


        public Order(Pizza pizza, Customer customer)
        {
            p = pizza;
            c = customer;
            Tax = 2;
            _deliveryCost = 40;
        }

        double Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }

        double DeliveryCost
        {
            get { return _deliveryCost; }
            set { _deliveryCost = value; }
        }

        public override string ToString()
        {
            return $"Pizza: {p.Name} - Customer: {c.Name} - Total price: {CalculateTotalPrice()}";
        }

        public double CalculateTotalPrice()
        {
            return p.Price * (1 + Tax / 100) + DeliveryCost;
        }
    }

}
