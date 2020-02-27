using ExamenVuelingLuisVallespin.Services.Deserializer;
using ExamenVuelingLuisVallespin.Services.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamenVuelingLuisVallespin.Tests.Services.Deserializer
{
    [TestClass()]
    public class GenericDeserializerTests
    {
        private readonly GenericDeserializer<Transaction> _deserializer = new GenericDeserializer<Transaction>();

        [TestMethod()]
        public void DeserializeTest()
        {
            var result = _deserializer.Deserialize(@"http://quiet-stone-2094.herokuapp.com/rates.json");
            Assert.IsNotNull(result);
            /*Assert.IsTrue(result);
            var failResult = _deserializer.Deserialize(@"NotAValidURL");
            Assert.IsFalse(failResult.IsCompleted);*/
        }
    }
}