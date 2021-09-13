using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> getAll();
        List<Car> getCarsByBrandId(int brandId);
        List<CarDetailDto> GetCarDetails();
        Car getById(int id);
        void add(Car car);
        void update(Car car);
        void delete(Car car);
    }
}
