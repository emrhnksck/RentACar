﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> getAll(Expression<Func<T,bool>> filter=null);

        T get(Expression<Func<T, bool>> filter);

        void add(T entity);

        void update(T entity);

        void delete(T entity);
    }
}
