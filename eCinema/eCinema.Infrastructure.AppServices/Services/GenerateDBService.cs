using eCinema.Core.Entities;
using eCinema.Infrastructure.DataMSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Infrastructure.AppServices.Services
{
    public class GenerateDBService : BaseService
    {

        public GenerateDBService(eCinemaDbContext context)
            :base(context)
        {

        }

        public List<Movie> GenerateDB()
        {
            return _uWork.MovieRepository.GetAll();
        }
    }
}
