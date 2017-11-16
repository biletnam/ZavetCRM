using System;

namespace CRMZavet.DAL.Entities
{
    public class AppPaste : IdProvider
    {
        public int? ProductId { get; set; }

        public int? StateId { get; set; }

        public int? PastaId { get; set; }

        public DateTime? Date { get; set; }

        public int? Count { get; set; }

        public virtual Paste Paste { get; set; }

        public virtual Product Product { get; set; }
    }
}