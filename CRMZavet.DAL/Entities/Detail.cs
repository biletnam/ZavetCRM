using System.Collections.Generic;

namespace CRMZavet.DAL.Entities
{
    public class Detail : IdProvider
    {
        public string Name { get; set; }
        public string VendorCode { get; set; }
        public int Quantity { get; set; }
        

        public virtual ICollection<StructureOfTheProduct> StructureOfTheProducts { get; set; }
        public virtual ICollection<ArrivalOfDetail> ArrivalOfDetailses { get; set; }
        public virtual ICollection<Defect> Defects { get; set; }
        public virtual ICollection<Silkscreen> Silkscreens { get; set; }
        

        public Detail()
        {
            StructureOfTheProducts = new List<StructureOfTheProduct>();
            ArrivalOfDetailses = new List<ArrivalOfDetail>();
            Defects = new List<Defect>();
            Silkscreens = new List<Silkscreen>();
        }
    }
}