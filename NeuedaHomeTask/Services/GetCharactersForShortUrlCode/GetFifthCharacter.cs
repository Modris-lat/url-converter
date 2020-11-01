using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuedaHomeTask.Interfaces;

namespace NeuedaHomeTask.Services.GetCharactersForShortUrlCode
{
    public class GetFifthCharacter: IGetChar
    {
        public string GetCharacter(string url)
        {
            return url.Count(char.IsLetter).ToString().Substring(0, 1);
        }
    }
}
