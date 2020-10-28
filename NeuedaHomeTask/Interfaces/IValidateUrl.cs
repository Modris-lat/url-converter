using System.Threading.Tasks;

namespace NeuedaHomeTask
{
    public interface IValidateUrl
    {
        Task<bool> CheckWebsite(string url);
    }
}
