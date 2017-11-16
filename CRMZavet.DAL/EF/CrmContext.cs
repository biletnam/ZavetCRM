using System.Data.Entity;
using System.Diagnostics;
using CRMZavet.DAL.Entities;
using CRMZavet.DAL.Interfaces;

namespace CRMZavet.DAL.EF
{
    public class CrmContext:DbContext, ICrmContext
    {
        public DbSet<Detail> Details { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Soldering> Solderings { get; set; }
        public DbSet<ArrivalOfDetail> ArrivalOfDetails { get; set; }
        public DbSet<Defect> Defects { get; set; }
        public DbSet<StructureOfTheProduct> StructureOfTheProducts { get; set; }
        public DbSet<Boxing> Boxings { get; set; }
        public DbSet<CheckEGR> CheckEgrs { get; set; }
        public DbSet<CheckJMT> CheckJmts { get; set; }
        public DbSet<Forwarding> Forwardings { get; set; }
        public DbSet<StateVariant> StateVariants { get; set; }
        public DbSet<StateProduct> StateProducts { get; set; }
        public DbSet<AppPaste> AppPastes { get; set; }
        public DbSet<Paste> Pastes { get; set; }
        public DbSet<Silkscreen> Silkscreens { get; set; }


        static CrmContext()
        {
            Database.SetInitializer<CrmContext>(new CrmDbInitializer());
        }
        public CrmContext()
            : base("CrmContextDb")
        {
        }
    }
        
    public class CrmDbInitializer : DropCreateDatabaseIfModelChanges<CrmContext>
    {
        protected override void Seed(CrmContext db)
        {
            var s1 = new Detail {Name = "Крышка под пружинку", VendorCode = "245-004", Quantity = 1000};
            var s2 = new Detail {Name = "Крышка корпуса", VendorCode = "245-003", Quantity = 1000};
            var s3 = new Detail {Name = "Крышка №", VendorCode = "245-004", Quantity = 1000};
            var s4 = new Detail {Name = "Корпус", VendorCode = "245-004", Quantity = 1000};
            var s5 = new Detail {Name = "Диск Верхний", VendorCode = "245-004", Quantity = 7000};
            var s6 = new Detail {Name = "Диск Нижний", VendorCode = "245-004", Quantity = 7000};
            var s7 = new Detail {Name = "Сетка", VendorCode = "245-004", Quantity = 7000};
            var s8 = new Detail {Name = "Шайба О", VendorCode = "245-004", Quantity = 7000};
            var s9 = new Detail {Name = "Шайба Н", VendorCode = "245-004", Quantity = 7000};
            var s10 = new Detail {Name = "Резинка", VendorCode = "245-004", Quantity = 1000};

            db.Details.Add(s1);
            db.Details.Add(s2);
            db.Details.Add(s3);
            db.Details.Add(s4);
            db.Details.Add(s5);
            db.Details.Add(s6);
            db.Details.Add(s7);
            db.Details.Add(s8);
            db.Details.Add(s9);
            db.Details.Add(s10);

            var p = new Product {Name = "5200-01"};
            db.Products.Add(p);

            var struc1 = new StructureOfTheProduct {Product = p, Detail = s1, Quantity = 1};
            var struc2 = new StructureOfTheProduct {Product = p, Detail = s2, Quantity = 1};
            var struc3 = new StructureOfTheProduct {Product = p, Detail = s3, Quantity = 1};
            var struc4 = new StructureOfTheProduct {Product = p, Detail = s4, Quantity = 1};
            var struc5 = new StructureOfTheProduct {Product = p, Detail = s5, Quantity = 6};
            var struc6 = new StructureOfTheProduct {Product = p, Detail = s6, Quantity = 6};
            var struc7 = new StructureOfTheProduct {Product = p, Detail = s7, Quantity = 6};
            var struc8 = new StructureOfTheProduct {Product = p, Detail = s8, Quantity = 7};
            var struc9 = new StructureOfTheProduct {Product = p, Detail = s9, Quantity = 6};
            var struc10 = new StructureOfTheProduct {Product = p, Detail = s10, Quantity = 1};
          
            db.StructureOfTheProducts.Add(struc1);
            db.StructureOfTheProducts.Add(struc2);
            db.StructureOfTheProducts.Add(struc3);
            db.StructureOfTheProducts.Add(struc4);
            db.StructureOfTheProducts.Add(struc5);
            db.StructureOfTheProducts.Add(struc6);
            db.StructureOfTheProducts.Add(struc7);
            db.StructureOfTheProducts.Add(struc8);
            db.StructureOfTheProducts.Add(struc9);
            db.StructureOfTheProducts.Add(struc10);
           
            db.SaveChanges();
        }
    }
    
}