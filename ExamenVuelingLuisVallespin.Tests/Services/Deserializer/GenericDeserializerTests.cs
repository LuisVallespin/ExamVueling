using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenVuelingLuisVallespin.Services.Deserializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.Deserializer.Tests
{
    [TestClass()]
    public class GenericDeserializerTests
    {
        private string _url = @"http://quiet-stone-2094.herokuapp.com/rates.json";
        private readonly GenericDeserializer<Transaction> _deserializer = new GenericDeserializer<Transaction>();

        [TestMethod()]
        public void DeserializeTest()
        {
            var result = _deserializer.Deserialize(_url);
            Assert.IsNotNull(result);
            
        }
    }
}