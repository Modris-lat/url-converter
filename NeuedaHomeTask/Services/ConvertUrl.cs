using NeuedaHomeTask.GetCharactersForShortUrlCode;
using NeuedaHomeTask.Interfaces;

namespace NeuedaHomeTask
{
    public class ConvertUrl: IConvertUrl
    {
        private IConstructUserInput _urlConstructUserInput;
        public string GetShorterUrl(string longUrl)
        {
            string name = longUrl.Replace("www", " ").Split(' ')[1].TrimStart('.');
            string firstChar = GetFirstChar.GetFirstCharacter(name);
            string secondChar = GetSecondChar.GetSecondCharacter(name);
            string thirdChar = GetThirdChar.GetThirdCharacter(name);
            string fourthChar = GetFourthChar.GetFourthCharacter(name);
            string fifthChar = GetFifthChar.GetFifthCharacter(name);
            string sixthChar = GetSixthChar.GetSixthCharacter(name);
            string shortUrlCode = firstChar + secondChar + thirdChar + fourthChar + fifthChar + sixthChar;
            return shortUrlCode;
        }
    }
}
