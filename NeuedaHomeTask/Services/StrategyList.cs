using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuedaHomeTask.Interfaces;
using NeuedaHomeTask.Services.GetCharactersForShortUrlCode;

namespace NeuedaHomeTask.Services
{
    public class StrategyList: IStrategyList
    {
        public StrategyList()
        {
            Strategies = new IGetChar[]
            {
                new GetFirstCharacter(), new GetSecondCharacter(), new GetThirdCharacter(), 
                new GetFourthCharacter(), new GetFifthCharacter(), new GetSixthCharacter(), 
            };
        }
        public IEnumerable<IGetChar> Strategies { get; set; }
    }
}
