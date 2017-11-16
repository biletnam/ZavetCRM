using System;

namespace CRMZavet.DAL.Entities
{
    public class Boxing : IdProvider
    {
        public int? ProductId { get; set; }

        public DateTime? Date { get; set; }

        public int? State { get; set; }

        public int? Count { get; set; }

        public virtual Product Product { get; set; }
    }
}