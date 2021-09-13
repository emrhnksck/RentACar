using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.InMemory
{
    public class InMemoryCarDao : ICarDao
    {

        List<Car> cars;

        public InMemoryCarDao()
        {
            cars = new List<Car>
            {
                new Car{id=1,brandId=5,modelYear=2010,dailyPrice=60,description="2010 model nice car"},
                new Car{id=2,brandId=3,modelYear=2011,dailyPrice=60,description="2011 model nice car"},
                new Car{id=3,brandId=10,modelYear=2013,dailyPrice=60,description="2013 model nice car"},
                new Car{id=4,brandId=7,modelYear=2020,dailyPrice=60,description="2020 model nice car"},
                new Car{id=5,brandId=2,modelYear=2018,dailyPrice=60,description="2018 model nice car"},

            };
        }

        public void add(Car car)
        {
            cars.Add(car);
        }

        public void delete(Car car)
        {
            Car deleteCar = cars.SingleOrDefault(c => c.id == car.id);
            cars.Remove(deleteCar);
        }

        public Car get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> getAll(Expression<Func<Car, bool>> filter = null)
        {
            return cars;
        }

        public Car getById(int id)
        {
            return cars.SingleOrDefault(c => c.id == id);
        }

        public List<CarDetailDto> getCarDetails()
        {
            throw new NotImplementedException();
        }

        public void update(Car car)
        {
            Car updateCar = cars.SingleOrDefault(c => c.id == car.id);
            updateCar.brandId = car.brandId;
            updateCar.colorId = car.colorId;
            updateCar.modelYear = car.modelYear;
            updateCar.dailyPrice = car.dailyPrice;
            updateCar.description = car.description;
        }
    }
}
