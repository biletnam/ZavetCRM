using System;
using System.Threading.Tasks;
using CRMZavet.DAL.Entities;

namespace CRMZavet.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<ArrivalOfDetail> ArrivalOfDetails { get; }
        IBaseRepository<Boxing> Boxings { get; }
        IBaseRepository<CheckEGR> CheckEGRs { get; }
        IBaseRepository<CheckJMT> CheckJMTs { get; }
        IBaseRepository<Defect> Defects { get; }
        IBaseRepository<Detail> Details { get; }
        IBaseRepository<Forwarding> Forwardings { get; }
        IBaseRepository<Product> Products { get; }
        IBaseRepository<Soldering> Solderings { get; }
        IBaseRepository<StateProduct> StateProducts { get; }
        IBaseRepository<StateVariant> StateVariants { get; }
        IBaseRepository<StructureOfTheProduct> StructureOfTheProducts { get; }
        IBaseRepository<AppPaste> AppPastes { get; }
        IBaseRepository<Paste> Pastes { get; }
        IBaseRepository<Silkscreen> Silkscreens { get; }
        
        Task Commit();

        void Rollback();
    }
}