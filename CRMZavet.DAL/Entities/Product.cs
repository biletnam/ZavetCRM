using System.Collections.Generic;

namespace CRMZavet.DAL.Entities
{
    public class Product : IdProvider
    {
        public string Name { get; set; }

        public virtual ICollection<StructureOfTheProduct> StructureOfTheProducts { get; set; }
        public virtual ICollection<Soldering> Solderings { get; set; }
        public virtual ICollection<AppPaste> AppPastes { get; set; }

        public Product()
        {
            StructureOfTheProducts = new List<StructureOfTheProduct>();
            Solderings = new List<Soldering>();
            AppPastes = new List<AppPaste>();
        }
    }
}