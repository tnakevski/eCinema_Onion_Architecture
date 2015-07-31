using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Core.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int GenreId { get; set; }
        public virtual ICollection<MovieActor> Actors { get; set; }
        public virtual ICollection<ShowTime> ShowTime { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }

        public Genre Genre { get; set; }

    }
}
