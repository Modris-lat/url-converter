using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuedaHomeTask.Interfaces;

namespace NeuedaHomeTask.Services.GetCharactersForShortUrlCode
{
    public class GetFourthCharacter: IGetChar
    {
        public string GetCharacter(string url)
        {
            return url[url.Length - 1].ToString().ToUpper();
        }
    }
}
