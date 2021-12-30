using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_bookstore.Models
{
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Mã hóa đơn không được bỏ trống")]
        [Display(Name ="Mã hóa đơn")]
        public string Code { get; set; }
        [Display(Name = "Mã tài khoản")]
        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Accounts Accounts { get; set; }
        [Display(Name = "Ngày Bán")]
        [DataType(DataType.DateTime)]
        public DateTime IssueDate { get; set; }
        [Display(Name = "Địa chỉ giao hàng")]
        public string ShippingAddress { get; set; }
        [Display(Name = "Số điện thoại người nhận")]
        public string ShippingPhone { get; set; }
        [Display(Name = "Tổng tiền")]
        public int Total { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
    }
}
