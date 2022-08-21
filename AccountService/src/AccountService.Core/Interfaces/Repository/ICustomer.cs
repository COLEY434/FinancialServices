using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountService.Core.Interfaces.Repository
{
    public interface ICustomer
    {
        Task Save();
    }
}
