using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_Bookstore.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Mã code sản phẩm")]
        [Required(ErrorMessage ="Chưa nhập mã code của sản phẩm"), MinLength(10,ErrorMessage ="Tối thiểu 10 ký tự")]
        [RegularExpression(@"^[a-zA-Z0-9]$")]
        public string SKU { get; set; }

        [DisplayName("Tên Sách")]
        [Required(ErrorMessage = "Chưa nhập tên sách"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"),MaxLength(255,ErrorMessage ="Nhập tối đa 255 kí tự")]
        [RegularExpression(@"^[a-zA-Z0-9\s]$")]
        public string Name { get; set; }

        [DisplayName("Tên tác giả")]
        [Required(ErrorMessage = "Chưa nhập tên tác giả"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(255, ErrorMessage = "Nhập tối đa 255 kí tự")]
        [RegularExpression(@"^[a-zA-Z0-9\s]$")]
        public string Actor { get; set; }

        [DisplayName("Mô tả")]
        [Required(ErrorMessage = "Chưa nhập mô tả"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(255, ErrorMessage = "Nhập tối đa 255 kí tự")]
        [RegularExpression(@"^[a-zA-Z0-9\s]$")]
        public string Decription { get; set; }

        [DisplayName("Đơn Giá")]
        [Required(ErrorMessage = "Chưa nhập đơn giá"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(255, ErrorMessage = "Nhập tối đa 255 kí tự")]
        [RegularExpression(@"^[0-9]$")]
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        public int Price { get; set; }

        [DisplayName("Tồn kho")]
        [Required(ErrorMessage = "Chưa nhập số lượng tồn kho"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(255, ErrorMessage = "Nhập tối đa 255 kí tự")]
        [RegularExpression(@"^[0-9]$")]
        public int Stock { get; set; }

        [DisplayName("Loại sách")]
        [Required(ErrorMessage = "Chưa nhập loại sách"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(255, ErrorMessage = "Nhập tối đa 255 kí tự")]
        [RegularExpression(@"^[a-zA-Z0-9\s]$")]
        public int ProductTypeId { get; set; }

        [DisplayName("Loại sách")]
        public ProductType ProductType { get; set; }

        [DisplayName("Hình ảnh")]
        [Required(ErrorMessage = "Chưa có hình ảnh")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Image { get; set; }

        [DisplayName("Trạng Thái")]
        public bool Status { get; set; }

        public List<Cart> Carts { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }

    }
}
