using System;
using System.Linq;
using System.Threading.Tasks;
using CRMZavet.DAL.Entities;
using CRMZavet.DAL.Interfaces;
using CRMZavet.DAL.Repositories;

namespace CRMZavet.DAL.EF
{
    public class UnitOfWork: IUnitOfWork
    {
        private bool _disposed = false;
        private readonly CrmContext _context;
        
        private IBaseRepository<ArrivalOfDetail> _arrivalOfDetailRepository;
        private IBaseRepository<Boxing> _boxingRepository;
        private IBaseRepository<CheckEGR> _checkEGRRepository;
        private IBaseRepository<CheckJMT> _checkJMTRepository;
        private IBaseRepository<Defect> _defectRepository;
        private IBaseRepository<Detail> _detailRepository;
        private IBaseRepository<Forwarding> _forwardingRepository;
        private IBaseRepository<Product> _productRepository;
        private IBaseRepository<Soldering> _solderingRepository;
        private IBaseRepository<StateProduct> _stateProductRepository;
        private IBaseRepository<StateVariant> _stateVariantRepository;
        private IBaseRepository<StructureOfTheProduct> _structureOfTheProductRepository;
        private IBaseRepository<AppPaste> _appPasteRepository;
        private IBaseRepository<Paste> _pasteRepository;
        private IBaseRepository<Silkscreen> _silkscreenRepository;
        
        

        public UnitOfWork()
        {
            _context = new CrmContext();
        }
        
        public IBaseRepository<ArrivalOfDetail> ArrivalOfDetails => _arrivalOfDetailRepository ?? 
                (_arrivalOfDetailRepository = new BaseRepository<ArrivalOfDetail>(_context));
        
        public IBaseRepository<Boxing> Boxings  => _boxingRepository ?? 
                                                   (_boxingRepository = new BaseRepository<Boxing>(_context));
       
        public IBaseRepository<CheckEGR> CheckEGRs => _checkEGRRepository ?? 
                                                      (_checkEGRRepository = new BaseRepository<CheckEGR>(_context));
      
        public IBaseRepository<CheckJMT> CheckJMTs=> _checkJMTRepository ?? 
                                                     (_checkJMTRepository = new BaseRepository<CheckJMT>(_context));
      
        public IBaseRepository<Defect> Defects => _defectRepository ?? 
                                                  (_defectRepository = new BaseRepository<Defect>(_context));
      
        public IBaseRepository<Detail> Details => _detailRepository ?? 
                                                  (_detailRepository = new BaseRepository<Detail>(_context));
        
        public IBaseRepository<Forwarding> Forwardings => _forwardingRepository ?? 
                                                     (_forwardingRepository = new BaseRepository<Forwarding>(_context));
        
        public IBaseRepository<Product> Products => _productRepository ?? 
                                                    (_productRepository = new BaseRepository<Product>(_context));
        
        public IBaseRepository<Soldering> Solderings => _solderingRepository ?? 
                                                       (_solderingRepository = new BaseRepository<Soldering>(_context));
        
        public IBaseRepository<StateProduct> StateProducts => _stateProductRepository ?? 
                                                 (_stateProductRepository = new BaseRepository<StateProduct>(_context));
        
        public IBaseRepository<StateVariant> StateVariants => _stateVariantRepository ?? 
                                                 (_stateVariantRepository = new BaseRepository<StateVariant>(_context));
        
        public IBaseRepository<StructureOfTheProduct> StructureOfTheProducts => _structureOfTheProductRepository ?? 
                               (_structureOfTheProductRepository = new BaseRepository<StructureOfTheProduct>(_context));
        
        public IBaseRepository<AppPaste> AppPastes => _appPasteRepository ?? 
                                                      (_appPasteRepository = new BaseRepository<AppPaste>(_context));
        
        public IBaseRepository<Paste> Pastes => _pasteRepository ?? 
                                                (_pasteRepository = new BaseRepository<Paste>(_context));
        
        public IBaseRepository<Silkscreen> Silkscreens => _silkscreenRepository ?? 
                                                          (_silkscreenRepository = new BaseRepository<Silkscreen>(_context));
        
        
        
        public async Task Commit()
            => await _context.SaveChangesAsync();

        public void Rollback()
            => _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
                if (disposing)
                    _context.Dispose();

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    
    }
}