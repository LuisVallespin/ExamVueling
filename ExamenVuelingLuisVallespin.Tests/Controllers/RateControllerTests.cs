using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenVuelingLuisVallespin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenVuelingLuisVallespin.Models;
using ExamenVuelingLuisVallespin.Services.Deserializer;
using ExamenVuelingLuisVallespin.Services.Factory;
using ExamenVuelingLuisVallespin.Services.Mapper;
using ExamenVuelingLuisVallespin.Services.Repository;
using ExamenVuelingLuisVallespin.Services.UrlChecker;
using Moq;
using Newtonsoft.Json;

namespace ExamenVuelingLuisVallespin.Controllers.Tests
{
    [TestClass()]
    public class RateControllerTests
    {
        private IGenericRepository<Rate> _repository;
        private RateController _controller;

        [TestInitialize]
        public void TestInitialize()
        {
            _repository = new FakeRateRepository();
            _controller = new RateController(_repository, new UrlChecker(), new GenericDeserializer<RateJson.Class1>(), new RateMapper(new RateFactory()));
        }

        [TestMethod()]
        public void RateControllerTest()
        {
            Assert.IsNotNull(_controller);
            Assert.IsInstanceOfType(_controller, typeof(RateController));
        }
        

        [TestMethod()]
        public async Task IndexTest()
        {
            var url = @"http://quiet-stone-2094.herokuapp.com/rates.json";
            var urlChecker = new Mock<UrlChecker>();
            var deserializer = new Mock<GenericDeserializer<RateJson.Class1>>();
            var mapper = new RateMapper(new RateFactory());

            var data = await deserializer.Object.Deserialize(url);
            var rates = await mapper.Map(data);

            var expectedData = JsonConvert.SerializeObject(rates);


            var actualData = await _controller.Index();

            Assert.IsNotNull(actualData);
            Assert.IsInstanceOfType(actualData, expectedData.GetType());

            Assert.IsInstanceOfType(_controller.Index(), typeof(Task<string>));

        }
    }
}