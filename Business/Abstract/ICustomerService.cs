using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult add(Customer customer);
        IDataResult<List<Customer>> getAll();
        IDataResult<Customer> getAllCustomers();
        IResult update(Customer customer);
        IResult delete(Customer customer);
    }
}
