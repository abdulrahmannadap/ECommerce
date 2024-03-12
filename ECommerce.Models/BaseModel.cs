using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            this.IsActive = true;
        }
        public int Id { get; set; }

        public bool IsActive { get; set; }
    }
}
