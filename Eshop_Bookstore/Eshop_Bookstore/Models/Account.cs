using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_Bookstore.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }

        public string Avatar { get; set; }
        [NotMapped]
        public IFormFile AvatarFile { get; set; }
        public bool Status { get; set; }

        public List<Cart> Carts { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}
