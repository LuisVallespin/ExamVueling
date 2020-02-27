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
    public class TransactionFactoryTests
    {
        private ITransactionFactory _factory;

        [TestInitialize]
        public void RateFactoryTest()
        {
            _factory = new TransactionFactory();
        }

        [TestMethod()]
        public void CreateInstanceTest()
        {
            Assert.IsNotNull(_factory.CreateInstance(new TransactionJson.Class1() { sku = "SKU1", amount = "24.04", currency = "USD"}));
        }
    }
}