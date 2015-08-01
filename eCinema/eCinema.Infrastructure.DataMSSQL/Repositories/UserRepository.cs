using eCinema.Core.Entities;
using eCinema.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Infrastructure.DataMSSQL.Repositories
{
    public class UserRepository : BaseRepository<User> , IUserRepository
    {
        public UserRepository(eCinemaDbContext context)
            :base (context)
        {
            
        }


        public User FindByUsernameAndPass(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            return user;
        }
    }
}
