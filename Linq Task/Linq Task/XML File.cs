using System.Collections.Generic;
using System;
using System.Xml.Linq;
using System.Linq;

namespace Linq_Task
{
    public class XML_File
    {
        private XML_File() { }
        public static XDocument LoadFile()
        {
            XDocument root = XDocument.Load("D:\\RD. HW - AT Lab#. 05 - Customers.xml");

            return root;
        }
    }
}

