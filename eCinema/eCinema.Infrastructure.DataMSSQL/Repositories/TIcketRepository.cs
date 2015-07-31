using eCinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Infrastructure.DataMSSQL.Repositories
{
    public class TicketRepository : BaseRepository<Ticket>
    {
        public TicketRepository(eCinemaDbContext context)
            :base(context)
        {

        }
    }
}
