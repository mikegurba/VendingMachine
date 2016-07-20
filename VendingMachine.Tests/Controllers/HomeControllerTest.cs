using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;
using VendingMachine.Controllers;
using VendingMachine.Models;

namespace VendingMachine.Tests.Controllers
{
    [TestClass]
    public class StartTest
    {
        [TestMethod]
        public void TestThatThereIsSeedData()
        {
            StartValues startValues = new StartValues();
            Assert.IsNotNull(startValues.customer);
            Assert.IsNotNull(startValues.inventory);
        }
    } 
    [TestClass]
    public class HomeControllerTest
    {
        
    }
}
