using eCinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Infrastructure.DataMSSQL.Repositories
{
    public class RatingRepository : BaseRepository<Rating>
    {
        public RatingRepository(eCinemaDbContext context)
            :base (context)
        {

        }
    }
}
