using System.Collections.Generic;
using System;
using System.Xml.Linq;
using System.Linq;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //No.1
            const double x = 1000.07;
            var _customers = from customerss in XML_File.LoadFile().Element("customers")
                                             .Elements()
                             where customerss.Element("orders").Elements("total").
                             Sum(n => double.Parse(n.Value)) > x
                             select customerss;

            foreach (var customerss in _customers)
            {
                Console.WriteLine((string)customerss.Element("name").Value);
            }

            //No.2
            var customersGroups = from cust in XML_File.LoadFile().Element("customers").Elements()
                                  group cust by cust.Element("country").Value;

            foreach (var c in customersGroups)
            {
                Console.WriteLine("-----");
                Console.WriteLine(c.Key);

                foreach (var i in c)
                    Console.WriteLine(i.Element("name").Value);
            }

            //No.3
            double order = 123.12;
            var customers_ = from c in XML_File.LoadFile().Element("customers").Elements()
                             where double.Parse(c.Element("total").Value) > order
                             select c;

            foreach (var c in customers_)
            {
                Console.WriteLine(c.Element("name").Value);
            }

            //4
            var firstOrder = from f in XML_File.LoadFile().Element("customers").Element("order").Elements().ElementAt(1).Elements()
                             select f;

            foreach (var f in firstOrder)
            {
                Console.WriteLine(f.Element("name").Value);
                Console.WriteLine(f.Element("orderdate").Value);
            }

            //6
            var customers = from customer in XML_File.LoadFile().Element("customers").Elements("customer")
                                //where customer.Elements("customer").ElementAt(5).Name == "region"
                            where customer.Element("phone").Value.Contains("(")
                            select customer;
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Element("name").Value);
            }

            //7
            var customersForACity = from cust in XML_File.LoadFile().Element("customers").Elements()
                                  group cust by cust.Element("city").Value;


            foreach (var c in customersForACity)
            {
                Console.WriteLine("-----");
                Console.WriteLine(c.Key);

                foreach (var i in c)
                {
                    int profitability = 0;
                    profitability = i.Element("customer").Elements("order").Elements("total").Average();
                }

            }
        }
    }
}

