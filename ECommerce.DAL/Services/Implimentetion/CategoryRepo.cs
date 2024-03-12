using ECommerce.DAL.Services.Interface;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Services.Implimentetion
{
    public class CategoryRepo : Repository<Category>, ICategoryRepo
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepo(ApplicationDbContext context):base(context)
        {
            _context = context;
             
        }
        public void Remove(int id)
        {
            var categoryIsDeleted = _context.Categories.Find(id);
            categoryIsDeleted.IsActive = false;

        }
    }
}
