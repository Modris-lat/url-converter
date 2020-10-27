using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using NeuedaHomeTask;

namespace Data.Library
{
    public interface IUrlStorageDBContext
    {
        DbSet<T> Set<T>() where T : class;
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
        Task<int> SaveChangesAsync();
        DbSet<UrlContainer> UrlContainers { get; set; }
    }
}
