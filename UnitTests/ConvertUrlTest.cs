using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeuedaHomeTask;
using NeuedaHomeTask.Interfaces;

namespace UnitTests
{
    [TestClass]
    public class ConvertUrlTest
    {
        private IConvertUrl convertMethod;
        
        public ConvertUrlTest()
        {
            IConstructUserInput construct = new ConstructUserUrlInput();
            convertMethod = new ConvertUrl();
        }
        [TestMethod]
        public void Test_Convert_Url_Base_Url_Long()
        {
            Assert.IsTrue(convertMethod.GetShorterUrl("http://www.some.com/page1/page2") == "243212");
        }
        [TestMethod]
        public void Test_Convert_Url_Base_Url_Short()
        {
            Assert.IsTrue(convertMethod.GetShorterUrl("http://www.some.com") == "84SM70");
        }
        [TestMethod]
        public void Test_Convert_Url_Base_Url_Short_Longer_Server_Name()
        {
            Assert.IsTrue(convertMethod.GetShorterUrl("http://www.somename.com") == "18SM10");
        }
        [TestMethod]
        public void Test_Convert_Url_Base_Url_Short_Server_Name_Starts_With_Number()
        {
            Assert.IsTrue(convertMethod.GetShorterUrl("http://www.24mename.com") == "182M92");
        }
    }
}
