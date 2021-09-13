using Business.Abstract;
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

        public void add(Car car)
        {
            if(car.description.Length > 2 && car.dailyPrice > 0)
            {
                carDao.add(car);
            }
            else
            {
                Console.WriteLine("Car couldn't add please check your informations");
            }
        }

        public void delete(Car car)
        {
            carDao.delete(car);
        }

        public List<Car> getAll()
        {
            return carDao.getAll();
        }

        public Car getById(int id)
        {
            return carDao.get(c=>c.id==id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return carDao.getCarDetails();
        }

        public List<Car> getCarsByBrandId(int brandId)
        {
            return carDao.getAll(c => c.brandId == brandId);
        }

        public List<Car> getCarsByColorId(int colorId)
        {
            return carDao.getAll(c => c.colorId == colorId);
        }

        public void update(Car car)
        {
            carDao.update(car);
        }
    }
}
