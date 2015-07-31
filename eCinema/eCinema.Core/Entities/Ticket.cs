using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Core.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int ShowTimeId { get; set; }
        public int UserId { get; set; }
        public ShowTime ShowTime { get; set; }
        public User User { get; set; }
    }
}
