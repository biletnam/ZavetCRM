using System;

namespace CRMZavet.BLL.DTO
{
    public class BoxingDTO : IdProviderDTO
    {
        public int? ProductId { get; set; }

        public DateTime? Date { get; set; }

        public int? State { get; set; }

        public int? Count { get; set; }
    }
}