using Business.Abstract;
using Business.Constants;
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
    public class CarManager : ICarService
    {
        ICarDao carDao;

        public CarManager(ICarDao carDao)
        {
            this.carDao = carDao;
        }

        public IResult add(Car car)
        {
            if(car.description.Length > 2 && car.dailyPrice > 0)
            {
                carDao.add(car);
                return new SuccesResult(Messages.carAdded);
            }
            else
            {
                return new ErrorResult(Messages.carCouldntAdd);
            }
        }

        public IResult delete(Car car)
        {
            carDao.delete(car);
            return new SuccesResult(Messages.carDeleted);
        }

        public IDataResult<List<Car>> getAll()
        {
            return new SuccessDataResult<List<Car>>(carDao.getAll(),Messages.getAllCars);
        }

        public IDataResult<Car> getById(int id)
        {
            return new SuccessDataResult<Car>(carDao.get(c=>c.id==id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(carDao.getCarDetails());
        }

        public IDataResult<List<Car>> getCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(carDao.getAll(c => c.brandId == brandId));
        }

        public IDataResult<List<Car>> getCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(carDao.getAll(c => c.colorId == colorId));
        }

        public IResult update(Car car)
        {
            carDao.update(car);
            return new SuccesResult();
        }
    }
}
