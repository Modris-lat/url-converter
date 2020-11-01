using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeuedaHomeTask;
using NeuedaHomeTask.Interfaces;
using NeuedaHomeTask.Services;
using NeuedaHomeTask.Services.GetCharactersForShortUrlCode;

namespace UnitTests
{
    [TestClass]
    public class ConvertUrlTest
    {
        private IConvertUrl _convertMethod;
        private IContexts _context;
        private IEnumerable<IGetChar> _strategies;
        

        public ConvertUrlTest()
        {
            _strategies = new StrategyList().Strategies;
            _context = new Context(new StrategyList());
            _convertMethod = new ConvertUrl(_context);
        }
        [TestMethod]
        public void Test_Convert_Url_Base_Url_Long()
        {
            Assert.IsTrue(_convertMethod.GetShorterUrl("http://www.some.com/page1/page2") == "243212");
        }
        [TestMethod]
        public void Test_Convert_Url_Base_Url_Short()
        {
            Assert.IsTrue(_convertMethod.GetShorterUrl("http://www.some.com") == "84SM70");
        }
        [TestMethod]
        public void Test_Convert_Url_Base_Url_Short_Longer_Server_Name()
        {
            Assert.IsTrue(_convertMethod.GetShorterUrl("http://www.somename.com") == "18SM10");
        }
        [TestMethod]
        public void Test_Convert_Url_Base_Url_Short_Server_Name_Starts_With_Number()
        {
            Assert.IsTrue(_convertMethod.GetShorterUrl("http://www.24mename.com") == "182M92");
        }
    }
}
