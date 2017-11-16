

namespace CRMZavet.BLL.DTO
{
    public class ArrivalOfDetailDTO : IdProviderDTO
    {
        public System.DateTime Data { get; set; }
        public int Count { get; set; }

        public int? DetailId { get; set; }
    }
}