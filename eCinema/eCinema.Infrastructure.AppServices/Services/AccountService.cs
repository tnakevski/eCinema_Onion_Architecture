using eCinema.Infrastructure.AppServices.DTOs;
using eCinema.Infrastructure.DataMSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Infrastructure.AppServices.Services
{
    public class AccountService : BaseService
    {
        public AccountService(eCinemaDbContext context)
            :base (context)
        {

        }

        public bool Login(LoginDto dto )
        {
            var user = _uWork.UserRepository.FindByUsernameAndPass(dto.Username, dto.Password);
            if (user == null)
                return false;
            else
                return true;
        }
    }
}
