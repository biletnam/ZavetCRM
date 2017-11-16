namespace CRMZavet.DAL.Entities
{
    public class Defect : IdProvider
    {
        public System.DateTime Date { get; set; }
        public int Count { get; set; }

        public int? DetailId { get; set; }
        public virtual Detail Detail { get; set; }
    }
}