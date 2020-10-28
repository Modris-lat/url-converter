using System.Linq;

namespace NeuedaHomeTask.GetCharactersForShortUrlCode
{
    public static class GetFifthChar
    {
        public static string GetFifthCharacter(string url)
        {
            return url.Count(char.IsLetter).ToString().Substring(0, 1);
        }
    }
}
