namespace Layered.Repository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Layered.Model.Models;

    public partial class ShopContext : DbContext
    {
        public ShopContext()
            : base("name=Shop")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.RRP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.SellingPrice)
                .HasPrecision(19, 4);
        }
    }
}
