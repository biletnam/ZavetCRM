using System;

namespace CRMZavet.BLL.DTO
{
    public class ForwardingDTO : IdProviderDTO
    {
        public DateTime? Date { get; set; }

        public int? ProductId { get; set; }

        public int? Count { get; set; }
    }
}