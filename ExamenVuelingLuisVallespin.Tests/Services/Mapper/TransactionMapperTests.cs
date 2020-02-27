using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenVuelingLuisVallespin.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenVuelingLuisVallespin.Models;
using ExamenVuelingLuisVallespin.Services.Factory;

namespace ExamenVuelingLuisVallespin.Services.Mapper.Tests
{
    [TestClass()]
    public class TransactionMapperTests
    {
        private ITransactionFactory _transactionFactory;
        private TransactionMapper _mapper;

        [TestInitialize]
        public void TransactionMapperTest()
        {
            _transactionFactory = new TransactionFactory();
            _mapper = new TransactionMapper(_transactionFactory);
        }
        
        [TestMethod()]
        public void MapTest()
        {
            var transactionJson = new TransactionJson.Class1() { sku = "ASD21", currency = "EUR", amount = "12.2"};
            Assert.IsNotNull(_mapper);
            Assert.IsNotNull(_mapper.Map(transactionJson));
            Assert.IsNotNull(_mapper.Map(new List<TransactionJson.Class1>() { transactionJson }));
        }

        [TestMethod()]
        public void EmptyTransactionMapperTest()
        {
            var emptyMapper = new TransactionMapper();
            Assert.IsNotNull(emptyMapper);

            
        }
    }
}