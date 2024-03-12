using ECommerce.DAL.Services.Interface;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Services.Implimentetion
{
    internal class ProductRepo : Repository<Product>, IProductRepo
    {
        private readonly ApplicationDbContext _context;
        public ProductRepo(ApplicationDbContext context) :base(context) 
        {
            
        }
        public void Remove(int id)
        {
            var productIsDeleted = _context.Products.Find(id);
            productIsDeleted.IsActive = false;
        }
    }
}
