using System;

namespace CRMZavet.BLL.DTO
{
    public class SilkscreenDTO : IdProviderDTO
    {
        public int DetailId { get; set; }

        public int PastaId { get; set; }

        public int CountDetail { get; set; }

        public int CountPasta { get; set; }

        public DateTime Date { get; set; }
    }
}