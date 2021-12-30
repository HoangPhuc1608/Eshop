using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_bookstore.Models
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Mã tài khoản")]
        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Accounts Accounts { get; set; }
        [Display(Name = "Mã sản phẩm")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
        [Display(Name = "số lượng")]
        public int Quanity { get; set; }
    }
}
