using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuedaHomeTask.Interfaces;

namespace NeuedaHomeTask.Services.GetCharactersForShortUrlCode
{
    public class GetSecondCharacter: IGetChar
    {
        public string GetCharacter(string url)
        {
            return url.Split('.')[0].Length.ToString().Substring(0, 1);
        }
    }
}
