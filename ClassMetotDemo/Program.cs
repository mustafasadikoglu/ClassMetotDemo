using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] c = new Customer[] {
            new Customer(){CustomerId=1,FirstName="Mustafa",LastName="Sadıkoğlu",TCNo="111111111",YearOfBirth="1993"},
            new Customer(){CustomerId=2,FirstName="Serhat",LastName="Kapucu",TCNo="222222222",YearOfBirth="1992"} };

            CustomerManager cm = new CustomerManager();
            cm.Add(c[0]);
            cm.Add(c[1]);
            Console.WriteLine("-------------------");

            cm.Delete(c[0]);

            Console.WriteLine("-------------------");

            cm.List(c);

            Console.ReadLine();


        }
    }
}
