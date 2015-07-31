using eCinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Infrastructure.DataMSSQL.Repositories
{
    public class HallRepository : BaseRepository<Hall>
    {
        public HallRepository(eCinemaDbContext context)
            : base(context)
        {

        }
    }
}
