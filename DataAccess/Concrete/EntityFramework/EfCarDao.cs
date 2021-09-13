using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDao : EfEntityRepository<Car, RentaCarContext>, ICarDao
    {
        public List<CarDetailDto> getCarDetails()
        {
            using(RentaCarContext context = new RentaCarContext())
            {
                var result = from c in context.Car
                             join b in context.Brand on c.brandId equals b.brandId
                             join co in context.Color on c.colorId equals co.colorId
                             select new CarDetailDto 
                             { carName=c.description, brandName=b.name, colorName=co.name, dailyPrice=c.dailyPrice };
                return result.ToList();
            }
        }
    }
}
