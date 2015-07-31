using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Core.Entities
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AvailableSeats { get; set; }
        public virtual ICollection<ShowTime> ShowTime { get; set; }
    }
}
