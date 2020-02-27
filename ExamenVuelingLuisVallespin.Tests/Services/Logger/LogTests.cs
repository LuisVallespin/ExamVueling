using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenVuelingLuisVallespin.Services.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.Logger.Tests
{
    [TestClass()]
    public class LogTests
    {
        private ILog _logger;

        [TestInitialize]
        public void LogTest()
        {
            _logger = new Log();
        }

        [TestMethod()]
        public void WriteToLogTest()
        {
            
            Assert.IsNotNull(_logger);
            Assert.IsTrue(_logger.WriteToLog("Testing").IsCompleted);
            Assert.IsInstanceOfType(_logger, typeof(Log));

        }
        
    }
}