using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_bookstore.Models
{
    [Table("Accounts")]
    public class Accounts
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Tài khoản không được bỏ trống"),MaxLength(20,ErrorMessage ="Tối đa 20 kí tự")]
        [Display(Name ="Tài khoản")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được bỏ trống"), MaxLength(20, ErrorMessage = "Tối đa 20 kí tự")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Họ tên không được bỏ trống")]
        [Display(Name = "Tên đầy đủ")]
        public string Fullname { get; set; }
        public bool IsAdmin { get; set; }
        [Display(Name = "Hình đại diện")]
        public string Avatar { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
    }
}
