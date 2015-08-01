using eCinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Core.Interfaces
{
    public interface IUserRepository
    {
        User FindByUsernameAndPass(string username, string password);
    }
}
