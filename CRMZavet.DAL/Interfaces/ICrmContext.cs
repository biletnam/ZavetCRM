using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CRMZavet.DAL.Entities;

namespace CRMZavet.DAL.Interfaces
{
    public interface ICrmContext
    {
        DbSet<Detail> Details { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Soldering> Solderings { get; set; }
        DbSet<ArrivalOfDetail> ArrivalOfDetails { get; set; }
        DbSet<Defect> Defects { get; set; }
        DbSet<StructureOfTheProduct> StructureOfTheProducts { get; set; }
        DbSet<Boxing> Boxings { get; set; }
        DbSet<CheckEGR> CheckEgrs { get; set; }
        DbSet<CheckJMT> CheckJmts { get; set; }
        DbSet<Forwarding> Forwardings { get; set; }
        DbSet<StateVariant> StateVariants { get; set; }
        DbSet<StateProduct> StateProducts { get; set; }
        DbSet<AppPaste> AppPastes { get; set; }
        DbSet<Paste> Pastes { get; set; }
        DbSet<Silkscreen> Silkscreens { get; set; }
        
        DbChangeTracker ChangeTracker { get; }

        int SaveChanges();

        void Dispose();

        DbEntityEntry Entry(object entity);

        DbSet<T> Set<T>() where T : class;
    }
}