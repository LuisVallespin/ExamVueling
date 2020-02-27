using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenVuelingLuisVallespin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenVuelingLuisVallespin.Models;
using ExamenVuelingLuisVallespin.Services.Deserializer;
using ExamenVuelingLuisVallespin.Services.Mapper;
using ExamenVuelingLuisVallespin.Services.Repository;
using ExamenVuelingLuisVallespin.Services.UrlChecker;

namespace ExamenVuelingLuisVallespin.Controllers.Tests
{
    [TestClass()]
    public class TransactionControllerTests
    {
        private TransactionController _controller;
        private  ITransactionRepository _repository;
        private  IUrlChecker _urlChecker;
        private  IGenericDeserializer<TransactionJson.Class1> _deserializer;
        private  ITransactionMapper _mapper;


        [TestInitialize]
        public void TransactionControllerTest()
        {
            _repository = new FakeTransactionRepository();
            _urlChecker = new UrlChecker();
            _deserializer = new GenericDeserializer<TransactionJson.Class1>();
            _mapper = new TransactionMapper();
            _controller = new TransactionController(_repository, _urlChecker, _deserializer, _mapper);
        }

        [TestMethod()]
        public void TransactionControllerTypeTest()
        {
            Assert.IsNotNull(_controller);
            Assert.IsInstanceOfType(_controller, typeof(TransactionController));
        }

        [TestMethod()]
        public async Task IndexTest()
        {
            var result = await _controller.Index();

            Assert.IsNotNull(result); 
            Assert.IsInstanceOfType(result, typeof(string));


            Assert.AreNotSame(_controller.Index(), _controller.Index());
            

            var emptyController = new TransactionController();
            Assert.IsNotNull(emptyController);
        }
    }
}