using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRMZavet.DAL.Entities
{
    public class Paste : IdProvider
    {
        public Paste()
        {
            AppPastes = new List<AppPaste>();
            Silkscreens = new List<Silkscreen>();
        }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Count { get; set; }
        
        public virtual ICollection<AppPaste> AppPastes { get; set; }
        public virtual ICollection<Silkscreen> Silkscreens { get; set; }
    }
}