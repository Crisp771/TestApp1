using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace TestAppData
{
    public interface ITestEntities : IDisposable
    {
        int SaveChanges();

        DbEntityEntry Entry(object entity);

        DbSet<tblPage> tblPages { get; set; }
        DbSet<tblRole> tblRoles { get; set; }
        DbSet<tblUser> tblUsers { get; set; }
        DbSet<tblSite> tblSites { get; set; }
        DbSet<tblSICLookup> tblSICLookups { get; set; }
    }
}