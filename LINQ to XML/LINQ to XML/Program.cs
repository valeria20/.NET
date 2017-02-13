using System.Collections.Generic;
using System;
using System.Xml.Linq;
using System.Linq;

namespace LINQ_to_XML
{

    public class Program
    {

        public static void Main(string[] args)
        {
            ////////No.1
            ////const double x = 1000;

            XDocument root = XDocument.Load("D:\\RD. HW - AT Lab#. 05 - Customers.xml");

            //var _customers = from customers in root.Element("customers")
            //                                 .Elements()
            //                 where customers.Descendants("total").
            //                 Sum(n => double.Parse(n.Value)) > x

            //                 select customers;

            //foreach (var customers in _customers)
            //{
            //    Console.WriteLine((string)customers.Element("name").Value);
            //}

            ////No.2

            //var customersGroups = from cust in root.Element("customers").Elements()
            //                      group cust by cust.Element("country").Value;

            //foreach (var c in customersGroups)
            //{
            //    Console.WriteLine("-----");
            //    Console.WriteLine(c.Key);

            //    foreach (var i in c)
            //        Console.WriteLine((string)i.Element("name").Value);
            //}


            //No.3
            Double order = new Double();
            order = 123.12;
            var customers = root.Descendants("customers").Where(e => System.Convert.ToDouble(e.Element("total").Value) > order);
            foreach (var e in customers)
            {
                Console.WriteLine(e.Element("name").Value); 
            }
            }

        }
    }
