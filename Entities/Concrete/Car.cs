using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int id { get; set; }
        public int brandId { get; set; }
        public int colorId { get; set; }
        public int modelYear { get; set; }
        public decimal dailyPrice { get; set; }
        public string description { get; set; }
    }
}
