using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDao rentalDao;

        public RentalManager(IRentalDao rentalDao)
        {
            this.rentalDao = rentalDao;
        }

        public IResult add(Rental rental)
        {
            rentalDao.add(rental);
            return new SuccesResult("Rental added");
        }

        public IResult delete(Rental rental)
        {
            rentalDao.delete(rental);
            return new SuccesResult("Rental deleted");
        }

        public IDataResult<List<Rental>> getAllRentals()
        {
            return new SuccessDataResult<List<Rental>>(rentalDao.getAll());
        }

        public IDataResult<List<RentalDetailDto>> getRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(rentalDao.getRentalDetails());
        }

        public IResult update(Rental rental)
        {
            rentalDao.update(rental);
            return new SuccesResult();
        }
    }
}
