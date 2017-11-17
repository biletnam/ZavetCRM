using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMZavet.Models
{
    public class DetailVM : IdProviderVM
    {
        public string Name { get; set; }
        public string VendorCode { get; set; }
        public int Quantity { get; set; }
    }
}