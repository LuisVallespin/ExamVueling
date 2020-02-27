using ExamenVuelingLuisVallespin.Services.Deserializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamenVuelingLuisVallespin.Tests.Services.Deserializer
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