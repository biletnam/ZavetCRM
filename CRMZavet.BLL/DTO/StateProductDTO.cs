namespace CRMZavet.BLL.DTO
{
    public class StateProductDTO : IdProviderDTO
    {
        public int ProductId { get; set; }

        public int? State { get; set; }

        public int? Count { get; set; }

    }
}