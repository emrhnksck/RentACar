using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFColorDao : IColorDao
    {
        public void add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> getAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
