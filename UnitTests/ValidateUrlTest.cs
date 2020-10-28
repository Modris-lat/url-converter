using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeuedaHomeTask;
using NeuedaHomeTask.Interfaces;

namespace UnitTests
{
    [TestClass]
    public class ValidateUrlTest
    {
        private IValidateUrl validate;
        private IConstructUserInput constructUserInput;
        public ValidateUrlTest()
        {
            constructUserInput = new ConstructUserUrlInput();
            validate = new ValidateUrl();
        }
        [TestMethod]
        public async Task Full_Url_String_Https()
        {
            var url = await constructUserInput.ConstructUrl(
                "https://www.stackoverflow.com/questions/26597665/how-to-get-content-body-from-a-httpclient-call");
            Assert.IsTrue(validate.CheckWebsite(
                url).Result);
        }
        [TestMethod]
        public async Task Full_Url()
        {
            var url = await constructUserInput.ConstructUrl(
                "https://www.codelex.io/programmesanas-kursi");
            Assert.IsTrue(validate.CheckWebsite(
                url).Result);
        }
        [TestMethod]
        public async Task Full_Url_String_Http()
        {
            var url = await constructUserInput.ConstructUrl(
                "http://www.stackoverflow.com/questions/26597665/how-to-get-content-body-from-a-httpclient-call");
            Assert.IsTrue(validate.CheckWebsite(
                url).Result);
        }
        [TestMethod]
        public async Task Url_String_With_WWW_And_Without_Http()
        {
            var url = await constructUserInput.ConstructUrl(
                "www.stackoverflow.com/questions/26597665/how-to-get-content-body-from-a-httpclient-call");
            Assert.IsTrue(validate.CheckWebsite(
                url).Result);
        }
        [TestMethod]
        public async Task Invalid_Url_String_With_Wrong_Http()
        {
            var url = await constructUserInput.ConstructUrl(
                "htt://stackoverflow.com/questions/26597665/how-to-get-content-body-from-a-httpclient-call");
            Assert.IsFalse(validate.CheckWebsite(
                url).Result);
        }
        [TestMethod]
        public async Task Invalid_Url_String_With_WW()
        {
            var url = await constructUserInput.ConstructUrl(
                "http://ww.stackoverflow.com/questions/26597665/how-to-get-content-body-from-a-httpclient-call");
            Assert.IsFalse(validate.CheckWebsite(
                url).Result);
        }
        [TestMethod]
        public async Task Invalid_Url_String_Without_COM()
        {
            var url = await constructUserInput.ConstructUrl(
                "http://www.stackoverflow/questions/26597665/how-to-get-content-body-from-a-httpclient-call");
            Assert.IsFalse(validate.CheckWebsite(
                url).Result);
        }
        [TestMethod]
        public async Task Valid_Url_String_With_More_Than_One_Dot_Server_Name()
        {
            var url = await constructUserInput.ConstructUrl(
                "http://structuremap.github.io/software-design-concepts/");
            Assert.IsTrue(validate.CheckWebsite(
                url).Result);
        }
    }
}
