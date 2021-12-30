using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_bookstore.Models
{
    [Table("ProductTypes")]
    public class ProductTypes
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Tên loại sản phẩm")]
        public string Name { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
    }
}
