using CRMZavet.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMZavet.BLL.Interfaces
{
    public interface IDetailOnProduct
    {
        IEnumerable<DetailDTO> GetDetail(int id);
    }
}
