using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_Bookstore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Actor { get; set; }
        public string Decription { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public bool Status { get; set; }

        public List<Cart> Carts { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }

    }
}
