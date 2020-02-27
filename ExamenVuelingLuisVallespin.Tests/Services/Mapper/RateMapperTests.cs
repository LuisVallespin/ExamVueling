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
    public class RateMapperTests
    {
        private IRateFactory _rateFactory;
        private RateMapper _mapper;

        [TestInitialize]
        public void RateMapperTest()
        {
            _rateFactory = new RateFactory();
            _mapper = new RateMapper(_rateFactory);
        }
        

        [TestMethod()]
        public async Task MapTest()
        {
            var rateJson = new RateJson.Class1() {from = "EUR", to = "CAD", rate = "1.24"};

            var list = await _mapper.Map(new List<RateJson.Class1>() {rateJson});


            Assert.IsNotNull(await _mapper.Map(rateJson));
            Assert.IsInstanceOfType(list, typeof(List<Rate>));
            Assert.IsNotNull(list);
        }
    }
}