using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> getAllRentals();
        IResult add(Rental rental);
        IDataResult<List<RentalDetailDto>> getRentalDetails();
        IResult update(Rental rental);

        IResult delete(Rental rental);

    }
}
