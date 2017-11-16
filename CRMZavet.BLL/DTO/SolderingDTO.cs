using System;

namespace CRMZavet.BLL.DTO
{
    public class SolderingDTO : IdProviderDTO
    {
        public DateTime Date { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
    }
}