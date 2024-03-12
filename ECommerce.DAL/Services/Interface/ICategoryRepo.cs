using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Services.Interface
{
    public interface ICategoryRepo :IRepository<Category>
    {
        void Remove(int id); 
    }
}
