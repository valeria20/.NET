using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Task
{
    public class Requests
    {
        public void First()
        {
            StreamWriter writer = new StreamWriter(@"D:\OUTPUT\1.txt");
            double x = 1000.08;
            var _customers = from customer in XML_File.LoadFile().Element("customers")
                                               .Elements()
                             where customer.Descendants("total").
                             Sum(n => double.Parse(n.Value)) > x

                             select customer;

            foreach (var customer in _customers)
            {
                writer.WriteLine(customer.Element("name").Value);
            }
        }

        public void Second() 
        {
            StreamWriter writer = new StreamWriter(@"D:\OUTPUT\2.txt");
            var customersGroups = from cust in XML_File.LoadFile().Element("customers").Elements()
                                  group cust by cust.Element("country").Value;

            foreach (var c in customersGroups)
            {
                writer.WriteLine("-----");
                writer.WriteLine(c.Key);

                foreach (var i in c)
                    writer.WriteLine(i.Element("name").Value);
            }
        }

        public void Third()
        {
            StreamWriter writer = new StreamWriter(@"D:\OUTPUT\3.txt");
            double X = 800;
            var customers_ = from c in XML_File.LoadFile().Element("customers").Elements("customer")
                             from f in c.Element("orders").Elements("order")
                             where double.Parse(f.Element("total").Value) > X
                             select c;                               

            foreach (var c in customers_)
            {
                writer.WriteLine(c.Element("name").Value);
            }
        }

        public void OrderWithMinDate()
        {
            StreamWriter writer = new StreamWriter(@"D:\OUTPUT\4.txt");
            var orders_ = from orders in XML_File.LoadFile().Element("customers").Elements("customer")
                          from c in orders.Element("orders").Elements("order").
                          OrderBy(c => c.Elements("orderdate").First().Value)
                          select c;
          foreach(var c in orders_)
            {
                writer.WriteLine(c.Element("orderdate").Value);
            }
        }

        public void Six()
        {
            StreamWriter writer = new StreamWriter(@"D:\OUTPUT\6.txt");
            
            var customers = from customer in XML_File.LoadFile().Element("customers").Elements("customer")
                           // where customer.Elements("customer").ElementAt(5).Name.ToString() == "region"
                            where customer.Element("phone").Value.Contains("(")==true
                            select customer;
            foreach (var customer in customers)
            {
                writer.WriteLine(customer.Element("name").Value);
            }
        }

        public void Seven()
        {
            StreamWriter writer = new StreamWriter(@"D:\OUTPUT\7.txt");

        }
    }
}
