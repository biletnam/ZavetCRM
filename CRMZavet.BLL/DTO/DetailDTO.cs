namespace CRMZavet.BLL.DTO
{
    public class DetailDTO : IdProviderDTO
    {
        public string Name { get; set; }
        public string VendorCode { get; set; }
        public int Quantity { get; set; }
    }
}