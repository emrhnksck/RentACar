using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDao
    {
        List<Car> getAll();

        Car getById(int id);

        void add(Car car);

        void update(Car car);

        void delete(Car car);
    }
}
