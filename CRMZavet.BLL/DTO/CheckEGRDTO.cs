using System;

namespace CRMZavet.BLL.DTO
{
    public class CheckEGRDTO : IdProviderDTO
    {
        public int State { get; set; }

        public DateTime Date { get; set; }

        public int Count { get; set; }

        public int? Airtight { get; set; }

        public int? TubeGrillBig { get; set; }

        public int? TubeGrillSmall { get; set; }

        public int? Perimeter { get; set; }

        public int? Flange { get; set; }

        public int? Tr { get; set; }

        public int? Brak { get; set; }

        public int ProductId { get; set; }
    }
}