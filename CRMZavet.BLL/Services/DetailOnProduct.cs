using CRMZavet.BLL.DTO;
using CRMZavet.BLL.Interfaces;
using CRMZavet.DAL.EF;
using CRMZavet.DAL.Entities;
using CRMZavet.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMZavet.BLL.Services
{
    public class DetailOnProduct : IDetailOnProduct
    {

        private readonly IUnitOfWork _uof;

        public DetailOnProduct(IUnitOfWork uof)
        {
            _uof = uof ?? throw new ArgumentNullException(nameof(uof));
        }

        public IEnumerable<DetailDTO> GetDetail(int id)
        {
            return _uof.StructureOfTheProducts.Entities.Where(t => t.ProductID == id).Select(x => new DetailDTO
            {
                Name = x.Detail.Name,
                Id = x.DetailID,
                Quantity = x.Detail.Quantity / x.Quantity
            });
        }

            
    }
}

