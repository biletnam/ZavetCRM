﻿using System;

namespace CRMZavet.DAL.Entities
{
    public class Soldering : IdProvider
    {
        public DateTime Date { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}