using System.Threading.Tasks;

namespace NeuedaHomeTask.Interfaces
{
    public interface IConstructUserInput
    {
        Task<string> ConstructUrl(string url);
    }
}
