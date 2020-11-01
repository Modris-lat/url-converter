using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuedaHomeTask.Interfaces;

namespace NeuedaHomeTask.Services
{
    public class Context: IContexts
    {
        private IEnumerable<IGetChar> _strategies;

        public Context(IStrategyList strategies)
        {
            _strategies = strategies.Strategies;
        }

        public string ExecuteStrategy(string url)
        {
            var shortUrl = string.Empty;
            foreach (var strategy in _strategies)
            {
                shortUrl += strategy.GetCharacter(url);
            }
            return shortUrl;
        }
    }
}
