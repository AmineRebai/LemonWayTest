using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonWayTest.Tests
{
    [TestClass]
    public class ConsoleAppTests
    {
        ConsoleApp.Client.localhost.WebService service = new ConsoleApp.Client.localhost.WebService();
        [TestMethod]
        public void ServiceConnectTest()
        {
            Assert.IsNotNull(service);
        }

        [TestMethod]
        public void FibonacciInRangeTest()
        {
            decimal fib = service.Fibonacci(10);
            Assert.AreEqual(fib, 55);
        }

        [TestMethod]
        public void FibonacciOutOfRangeTest()
        {
            decimal fib = service.Fibonacci(1000);
            Assert.AreEqual(fib, -1);
        }

        [TestMethod]
        public void XmlToJsonTest()
        {
            string json = service.XmlToJson("<foo>Hello World!</foo>");
            Assert.AreEqual(json, "{\"foo\":\"Hello World!\"}");
        }

        [TestMethod]
        public void XmlToJsonTestBadFormat()
        {
            string json = service.XmlToJson("<foo>Hello World!</bar>");
            Assert.AreEqual(json, "Bad Xml format");
        }
    }
}
