using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_bookstore.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Mã sản phẩm")]
        public string SKU { get; set; }
        [Required(ErrorMessage ="Tên sản phẩm không được bỏ trống")]
        [Display(Name ="Tên sản phẩm")]
        public string Name { get; set; }
        [Display(Name = "Mô tả")]
        public string Decription { get; set; }
        [Display(Name = "Giá")]
        public int Price { get; set; }
        [Display(Name = "Số lượng tồn kho")]
        public int Stock { get; set; }
        [Display(Name = "Mã loại sản phẩm")]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public ProductTypes ProductTypes { get; set; }
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }
        [Display(Name = "Trạng Thái")]
        public bool Status { get; set; }
    }
}
