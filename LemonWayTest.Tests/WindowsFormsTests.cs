using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonWayTest.Tests
{
    [TestClass]
    public class WindowsFormsTests
    {
        WindowsForms.Client.Form1 form = new WindowsForms.Client.Form1();
        WindowsForms.Client.localhost.WebService service = new WindowsForms.Client.localhost.WebService();
        [TestMethod]
        public void ServiceConnectTest()
        {
            Assert.IsNotNull(service);
        }

        [TestMethod]
        public void FibonacciInRangeTest()
        {
            decimal fib = form.Fibonacci(service, 10);
            Assert.AreEqual(fib, 55);
        }

        [TestMethod]
        public void FibonacciOutOfRangeTest()
        {
            decimal fib = form.Fibonacci(service, 1000);
            Assert.AreEqual(fib, -1);
        }
    }
}
