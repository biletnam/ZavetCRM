namespace CRMZavet.BLL.DTO
{
    public class DefectDTO : IdProviderDTO
    {
        public System.DateTime Date { get; set; }
        public int Count { get; set; }

        public int? DetailId { get; set; }
    }
}