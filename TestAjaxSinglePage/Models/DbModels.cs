using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestAjaxSinglePage.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }
        public String PName { get; set; }
        public int Price { get; set; }
        public bool IsAviable { get; set; }
        public DateTime Pdate { get; set; }
        public string Image { get; set; }
        public virtual IList<Details> Details { get; set; }
    }
    public class Color
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CId { get; set; }
        public string CName { get; set; }
        public virtual IList<Details> Details { get; set; }
    }
    public class Details
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DId { get; set; }
        [ForeignKey("Product")]
        public int PId { get; set; }
        [ForeignKey("Color")]
        public int CId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Color Color { get; set; }
    }
    public class ProductDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Details> Details { get; set; }
    }
   
}