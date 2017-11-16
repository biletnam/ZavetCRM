namespace CRMZavet.DAL.Entities
{
    public class ArrivalOfDetail : IdProvider
    {
        public System.DateTime Data { get; set; }
        public int Count { get; set; }

        public int? DetailId { get; set; }
        public virtual Detail Detail { get; set; }
    }
}