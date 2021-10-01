using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDao:EfEntityRepository<Rental,RentaCarContext>,IRentalDao
    {

        public List<RentalDetailDto> getRentalDetails()
        {
            using(RentaCarContext context = new RentaCarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Car on r.CarId equals c.id
                             join cu in context.Customers on r.CustomerId equals cu.customerId
                             join u in context.User on cu.userId equals u.userId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarName = c.description,
                                 CustomerName = u.firstName,
                                 RentDate = r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
