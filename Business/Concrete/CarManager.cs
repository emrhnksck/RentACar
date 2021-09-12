using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
            carDao.add(car);
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
            return carDao.getById(id);
        }

        public void update(Car car)
        {
            carDao.update(car);
        }
    }
}
