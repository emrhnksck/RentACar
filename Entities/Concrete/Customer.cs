using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int customerId { get; set; }
        public string companyName { get; set; }
        public int userId { get; set; }
    }
}
