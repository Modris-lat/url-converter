using System.Threading.Tasks;
using NeuedaHomeTask.Interfaces;

namespace NeuedaHomeTask
{
    public class ConstructUserUrlInput: IConstructUserInput
    {
        public Task<string> ConstructUrl(string url)
        {
            if (url.StartsWith("www"))
            {
                url = "http://" + url;
            }
            return Task.FromResult(url);
        }
    }
}
