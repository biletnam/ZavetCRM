﻿using System;

namespace CRMZavet.DAL.Entities
{
    public class CheckJMT : IdProvider
    {
        public int State { get; set; }

        public DateTime Date { get; set; }

        public int Count { get; set; }

        public int? Airtight { get; set; }

        public int? CapM { get; set; }

        public int? CapN { get; set; }

        public int? Shell { get; set; }

        public int? Tube { get; set; }

        public int? Center { get; set; }

        public int? Defect { get; set; }

        public int ProductId { get; set; }
        
        public virtual Product Product { get; set; }
       
    }
}
