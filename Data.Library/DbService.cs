using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Library.Interfaces;
using NeuedaHomeTask;

namespace Data.Library
{
    public class DbService: IDbService
    {
        protected readonly IUrlStorageDBContext _ctx;

        public DbService(IUrlStorageDBContext context)
        {
            _ctx = context;
        }

        public Task<ServiceResult> AddItem(UrlContainer url)
        {
            if (url == null)
            {
                return Task.FromResult(new ServiceResult(false));
            }
            _ctx.UrlContainers.Add(url);
            _ctx.SaveChangesAsync();
            return Task.FromResult(new ServiceResult(true));
        }

        public Task<UrlContainer> GetItem(string url)
        {
            var item = _ctx.UrlContainers.SingleOrDefault(u => 
                u.LongUrl == url || u.ShortUrl == url);
            return Task.FromResult(item);
        }

        public Task<ServiceResult> DeleteItem(string url)
        {
            var item = _ctx.UrlContainers.SingleOrDefault(u => u.LongUrl == url ||
                                                               u.ShortUrl == url);
            if (item == null)
            {
                return Task.FromResult(new ServiceResult(false));
            }

            _ctx.UrlContainers.Remove(item);
            _ctx.SaveChangesAsync();
            return Task.FromResult(new ServiceResult(true));
        }

        public Task<ServiceResult> ClearData()
        {
            _ctx.UrlContainers.RemoveRange(_ctx.UrlContainers);
            _ctx.SaveChangesAsync();
            return Task.FromResult(new ServiceResult(true));
        }
    }
}
