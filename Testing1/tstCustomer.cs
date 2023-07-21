using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }
    }
}
