using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        
                         
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName+customer.LastName} isimli müşteri eklendi");
        }
       
        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName + customer.LastName} isimli müşteri silindi");
        }
        
        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName);
            }
        }

       
    }
}
