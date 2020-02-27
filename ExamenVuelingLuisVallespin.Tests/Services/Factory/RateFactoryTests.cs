using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenVuelingLuisVallespin.Services.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenVuelingLuisVallespin.Models;

namespace ExamenVuelingLuisVallespin.Services.Factory.Tests
{
    [TestClass()]
    public class RateFactoryTests
    {
        private IRateFactory _factory;

        [TestInitialize]
        public void RateFactoryTest()
        {
            _factory = new RateFactory();
        }

        [TestMethod()]
        public void CreateInstanceTest()
        {
            Assert.IsNotNull(_factory.CreateInstance(new RateJson.Class1(){from = "USD", rate = "0.62", to = "EUR"}));
        }
    }
}