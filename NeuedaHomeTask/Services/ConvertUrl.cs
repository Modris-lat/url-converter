
using NeuedaHomeTask.Interfaces;
using NeuedaHomeTask.Services.GetCharactersForShortUrlCode;

namespace NeuedaHomeTask
{
    public class ConvertUrl: IConvertUrl
    {
        private IContexts _context;

        public ConvertUrl(IContexts context)
        {
            _context = context;
        }
        public string GetShorterUrl(string longUrl)
        {
            string name = longUrl.Replace("www", " ").Split(' ')[1].TrimStart('.');
            return _context.ExecuteStrategy(name);
        }
    }
}
