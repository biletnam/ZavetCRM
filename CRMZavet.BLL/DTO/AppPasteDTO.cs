using System;

namespace CRMZavet.BLL.DTO
{
    public class AppPasteDTO : IdProviderDTO
    {
        public int? ProductId { get; set; }

        public int? StateId { get; set; }

        public int? PastaId { get; set; }

        public DateTime? Date { get; set; }

        public int? Count { get; set; }

    }
}