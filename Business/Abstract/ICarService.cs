using Entities.Concrete;
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

        Car getById(int id);

        void add(Car car);

        void update(Car car);

        void delete(Car car);
    }
}
