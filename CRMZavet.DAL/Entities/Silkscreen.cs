using System;

namespace CRMZavet.DAL.Entities
{
    public class Silkscreen : IdProvider
    {
        public int DetailId { get; set; }

        public int PastaId { get; set; }

        public int CountDetail { get; set; }

        public int CountPasta { get; set; }

        public DateTime Date { get; set; }

        public virtual Detail Detail { get; set; }

        public virtual Paste Paste { get; set; }
    }
}