using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Core.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public virtual ICollection<MovieActor> Movies { get; set; }
    }
}
