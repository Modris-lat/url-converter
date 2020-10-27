using System.Linq;

namespace NeuedaHomeTask.GetCharactersForShortUrlCode
{
    public static class GetSixthChar
    {
        public static string GetSixthCharacter(string url)
        {
            return url.Count(char.IsDigit).ToString().Substring(0, 1);
        }
    }
}
