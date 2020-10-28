using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Data.Library;
using Data.Library.Interfaces;
using NeuedaHomeTask;
using NeuedaHomeTask.Interfaces;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DefaultController: ApiController
    {
        private IConvertUrl _convertUrl;
        private IValidateUrl _validateUrl;
        private IDbService _urlStorage;
        private IConstructUserInput _constructInput;

        public DefaultController(IConstructUserInput constructInput, IValidateUrl validate,
            IDbService storage, IConvertUrl convert)
        {
            _constructInput = constructInput;
            _validateUrl = validate;
            _convertUrl = convert;
            _urlStorage = storage;
        }

        [HttpPut, Route("default-api/url")]
        public async Task<IHttpActionResult> AddLongUrl(UrlRequest longUrl)
        {
            var url = await _constructInput.ConstructUrl(longUrl.Url);
            var result = await _validateUrl.CheckWebsite(url);
            if (result)
            {
                var urlSearch = await _urlStorage.GetItem(url);
                if (urlSearch == null)
                {
                    var shortUrlCode = _convertUrl.GetShorterUrl(url);
                    var container = new UrlContainer { LongUrl = url, ShortUrl = shortUrlCode };
                    await _urlStorage.AddItem(container);
                    return Ok($"http://home/{container.ShortUrl}");
                }

                return Ok($"http://home/{urlSearch.ShortUrl}");
            }
            return BadRequest();
        }
        [HttpGet, Route("default-api/url")]
        public async Task<IHttpActionResult> GetLongUrl(UrlRequest url)
        {
            var urlSearch = await _urlStorage.GetItem(url.Url);
            if (urlSearch != null)
            {
                return Ok(urlSearch.LongUrl);
            }

            return NotFound();
        }
        [HttpPost, Route("default-api/url/{value}")]
        public async Task<IHttpActionResult> ClearAllData(string value)
        {
            if (value == "clear")
            {
                await _urlStorage.ClearData();
            }
            return Ok();
        }
    }
}
