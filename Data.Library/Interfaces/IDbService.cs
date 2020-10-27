using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuedaHomeTask;

namespace Data.Library.Interfaces
{
    public interface IDbService
    {
        Task<ServiceResult> AddItem(UrlContainer url);
        Task<UrlContainer> GetItem(string url);
        Task<ServiceResult> DeleteItem(string url);
        Task<ServiceResult> ClearData();
    }
}
