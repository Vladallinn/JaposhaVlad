using newjaposha.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newjaposha.Catalogs
{//Andrei Sarbu
    public class CustomerCatalog
    {
        List<Customer> _customers;

        public CustomerCatalog()
        {
            _customers = new List<Customer>();
        }

        public void Addcustomer(Customer c) { _customers.Add(c); }
        public void Removecustomer(Customer c) { _customers.Remove(c); }
        public Customer Searchcustomer(int id)
        {
            foreach (Customer c in _customers)
            {
                if (c.Id == id) { return c; }
            }
            return null;
        }

        public void DisplayContent()
        {
            foreach (var item in _customers)
            {
                Console.WriteLine(item);
            }
        }



    }
}
