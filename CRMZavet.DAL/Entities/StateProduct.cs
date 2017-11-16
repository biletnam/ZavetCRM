using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMZavet.DAL.Entities
{
    public class StateProduct : IdProvider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public int? State { get; set; }

        public int? Count { get; set; }

        public virtual Product Product { get; set; }

        public virtual StateVariant StateVariant { get; set; }
    }
}