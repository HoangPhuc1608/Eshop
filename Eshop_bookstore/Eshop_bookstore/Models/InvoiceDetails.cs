using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_bookstore.Models
{
    [Table("InvoiceDetails")]
    public class InvoiceDetails
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Mã hóa đơn")]
        public int InvoiceId { get; set; }
        [ForeignKey("InvoiceId")]
        public Invoices Invoices { get; set; }
        [Display(Name = "Mã sản phẩm")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }
        [Display(Name = "Giá")]
        public int UnitPrice { get; set; }
    }
}
