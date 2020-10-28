using System.Data.Entity;
using Data.Library.Migrations;
using NeuedaHomeTask;

namespace Data.Library
{
    public class UrlStorageDBContext: DbContext, IUrlStorageDBContext
    {
        public UrlStorageDBContext() : base("url-storage")
        {
            Database.SetInitializer<UrlStorageDBContext>(null);
            Database.SetInitializer<UrlStorageDBContext>(
                new MigrateDatabaseToLatestVersion<UrlStorageDBContext, Configuration
                >());
        }

        public DbSet<UrlContainer> UrlContainers { get; set; }
    }
}
