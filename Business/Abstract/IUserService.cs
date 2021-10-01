﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> getAllUsers();

        IResult add(User user);

        IResult update(User user);

        IResult delete(User user);
    }
}
