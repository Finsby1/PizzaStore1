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
            Tax = 2;
            _deliveryCost = 30;
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
            return $"Pizza: {p.Name} - Tax: {Tax} - Delivery Cost: {DeliveryCost} - Total: {CalculateTotalPrice()}";
        }

        public double CalculateTotalPrice()
        {
            return p.Price * (1 + Tax / 100) + DeliveryCost;
        }
    }

}
