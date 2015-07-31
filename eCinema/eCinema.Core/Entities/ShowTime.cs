using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Core.Entities
{
    public class ShowTime
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        public Movie Movie { get; set; }
        public Hall Hall { get; set; }
    }
}
