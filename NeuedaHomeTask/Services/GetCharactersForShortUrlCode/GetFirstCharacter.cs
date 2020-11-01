using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuedaHomeTask.Interfaces;

namespace NeuedaHomeTask.Services.GetCharactersForShortUrlCode
{
    public class GetFirstCharacter: IGetChar
    {
        public string GetCharacter(string url)
        {
            return url.Length.ToString().Substring(0, 1);
        }
    }
}
