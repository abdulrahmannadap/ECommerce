using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Services.Interface
{
    public interface IProductRepo : IRepository<Product>
    {
        void Remove(int id);

    }
}
