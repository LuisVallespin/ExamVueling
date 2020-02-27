using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenVuelingLuisVallespin.Services.UrlChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.UrlChecker.Tests
{
    [TestClass()]
    public class UrlCheckerTests
    {
        private IUrlChecker _urlChecker;
        [TestInitialize]
        public void UrlCheckerTest()
        {
            _urlChecker = new UrlChecker();
        }

        [TestMethod()]
        public async Task CheckTest()
        {
            Assert.IsTrue(await _urlChecker.Check("http://quiet-stone-2094.herokuapp.com/transactions.json"));
        }
    }
}