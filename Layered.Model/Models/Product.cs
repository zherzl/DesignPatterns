using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Model.Models
{
    [Table("dbo.Product")]
    public partial class Product
    {
        public Product()
        {
            Price = new Price(0.0m, 0.0m);
        }

        [Key]
        [Column(Order = 0)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal RRP { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal SellingPrice { get; set; }

        [NotMapped]
        public Price Price { get; set; }
    }
}
