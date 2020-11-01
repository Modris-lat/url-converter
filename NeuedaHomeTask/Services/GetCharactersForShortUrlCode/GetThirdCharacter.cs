using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuedaHomeTask.Interfaces;

namespace NeuedaHomeTask.Services.GetCharactersForShortUrlCode
{
    public class GetThirdCharacter: IGetChar
    {
        public string GetCharacter(string url)
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
