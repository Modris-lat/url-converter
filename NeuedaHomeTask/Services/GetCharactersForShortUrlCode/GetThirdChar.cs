using System.Linq;

namespace NeuedaHomeTask.GetCharactersForShortUrlCode
{
    public static class GetThirdChar
    {
        public static string GetThirdCharacter(string url)
        {
            string separatedLength = "";
            if (url.Contains('/'))
            {
                separatedLength = url.Split('/').Length.ToString().Substring(0, 1);
                return separatedLength;
            }
            separatedLength = url[0].ToString().ToUpper();
            return separatedLength;
        }
    }
}
