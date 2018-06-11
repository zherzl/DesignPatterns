//namespace Layered.Repository
//{
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Data.Entity.Spatial;

//    [Table("Product")]
//    public partial class Product
//    {
//        [Key]
//        [Column(Order = 0)]
//        public int ProductId { get; set; }

//        [Key]
//        [Column(Order = 1)]
//        [StringLength(50)]
//        public string ProductName { get; set; }

//        [Key]
//        [Column(Order = 2, TypeName = "money")]
//        public decimal RRP { get; set; }

//        [Key]
//        [Column(Order = 3, TypeName = "money")]
//        public decimal SellingPrice { get; set; }
//    }
//}
