using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenVuelingLuisVallespin.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenVuelingLuisVallespin.Services.Repository;

namespace ExamenVuelingLuisVallespin.Services.Products.Tests
{
    [TestClass()]
    public class SumOfAllProductsTests
    {
        private ITransactionRepository _repository;
        private SumOfAllProducts _sumOfAllProducts;

        [TestInitialize]
        public void SumOfAllProductsTest()
        {
            _repository = new FakeTransactionRepository();
            _sumOfAllProducts = new SumOfAllProducts(_repository);
        }
        

        [TestMethod()]
        public async Task GetTest()
        {
            Assert.IsNotNull(_sumOfAllProducts);

            Assert.IsNotNull(await _sumOfAllProducts.Get());

            Assert.IsInstanceOfType(await _sumOfAllProducts.Get(), typeof( Dictionary<string, decimal>));
        }
    }
}