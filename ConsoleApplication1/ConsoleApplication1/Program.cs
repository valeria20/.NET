using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.First();
            obj.Second();
            obj.Third();
            Console.ReadKey();
  
        }

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
            double X = 123.12;
            var customers_ = from c in XML_File.LoadFile().Element("customers").Descendants("total")
                             where double.Parse(c.Element("total").Value)>X
                             select c;

            foreach (var f in customers_)
            {
                writer.WriteLine(f.Element("name").Value);
            }
        }

    }
}
