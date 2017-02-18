using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linq_Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Task.Tests
{
    [TestClass()]
    public class RequestsTests : Requests
    {
        [TestMethod()]
        public void FirstTest()
        {
            RequestsTests obj = new RequestsTests();
            obj.First();
        }

        [TestMethod()]
        public void SecondTest()
        {
            RequestsTests obj = new RequestsTests();
            obj.Second();
        }

        [TestMethod()]
        public void ThirdTest()
        {
            RequestsTests obj = new RequestsTests();
            obj.Third();
        }

        [TestMethod()]
        public void OrderWithMinDateTest()
        {
            RequestsTests obj = new RequestsTests();
            obj.OrderWithMinDate();
        }

        [TestMethod()]
        public void SixTest()
        {
            RequestsTests obj = new RequestsTests();
            obj.Six();
        }
    }
}