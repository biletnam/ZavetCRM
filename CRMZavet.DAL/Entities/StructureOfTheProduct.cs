using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMZavet.DAL.Entities
{
    public class StructureOfTheProduct : IdProvider
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Detail Detail { get; set; }
        public virtual Product Product { get; set; }
    }
}