using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore1
{
    public class Customer
    {
        string _name;
        string _phonenr;
        string _email;
        string _address;

        public Customer()
        {
            _name = "";
            _phonenr = "";
            _email = "";
            _address = "";
        }

        public Customer(string name, string phonenr, string email, string address)
        {
            _name = name;
            _phonenr = phonenr;
            _email = email;
            _address = address;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Phonenr
        {
            get { return _phonenr; }
            set { _phonenr = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
    

        public override string ToString()
        {
            return $"Name: {Name} - Phone nr. {Phonenr} - E-mail {Email} - Address {Address}";
        }
        
    }
}
