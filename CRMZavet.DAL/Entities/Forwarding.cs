using System;

namespace CRMZavet.DAL.Entities
{
    public class Forwarding : IdProvider
    {
        public DateTime? Date { get; set; }

        public int? ProductId { get; set; }

        public int? Count { get; set; }

        public virtual Product Product { get; set; }
    }
}