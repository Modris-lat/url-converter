using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuedaHomeTask.Interfaces;

namespace NeuedaHomeTask.Services
{
    public interface IStrategyList
    {
        IEnumerable<IGetChar> Strategies { get; set; }
    }
}
