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
        CrmContext db = new CrmContext();
        private readonly IUnitOfWork _uof;

        public DetailOnProduct(IUnitOfWork uof)
        {
            _uof = uof ?? throw new ArgumentNullException(nameof(uof));
        }

        public IEnumerable<DetailDTO> GetDetail(int id)
        {
            List<DetailDTO> list = new List<DetailDTO>();
            var prod = db.StructureOfTheProducts.Include("Detail").Where(t => t.ProductID == id).ToList();

            foreach (var item in prod)
            {
                DetailDTO detailDTO = new DetailDTO();
                detailDTO.Name = item.Detail.Name;
                detailDTO.Id = item.DetailID;
                detailDTO.Quantity = item.Detail.Quantity / item.Quantity;
                list.Add(detailDTO);
            }
            return list;
        }
    }
}
