using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRMZavet.DAL.Entities
{
    public class StateVariant : IdProvider
    {
        [StringLength(50)]
        public string Name { get; set; }

       
        public virtual ICollection<StateProduct> StateProduct { get; set; }
    }
}