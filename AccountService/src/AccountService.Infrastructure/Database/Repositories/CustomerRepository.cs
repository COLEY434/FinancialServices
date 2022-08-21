using AccountService.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountService.Infrastructure.Database.Repositories
{
    public class CustomerRepository : ICustomer
    {
        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
