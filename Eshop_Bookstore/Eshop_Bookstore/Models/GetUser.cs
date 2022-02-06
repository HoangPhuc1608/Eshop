using Eshop_Bookstore.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_Bookstore.Models
{
    public  class GetUser
    {
        static Eshop_BookstoreContext _context;
        public static   Task<Account> getUser(string userName)
        {
            var a = _context.Accounts.FirstOrDefaultAsync(u => u.Username == userName);
            return  _context.Accounts.FirstOrDefaultAsync(u => u.Username == userName);
        }
    }
}
