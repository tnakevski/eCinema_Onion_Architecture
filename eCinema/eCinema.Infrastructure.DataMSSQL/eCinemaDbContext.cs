using eCinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Infrastructure.DataMSSQL
{
    public class eCinemaDbContext : DbContext
    {
        public eCinemaDbContext()
            : base("eCinemaDbContext")
        {

        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres{ get; set; }
        public DbSet<Hall> Halls{ get; set; }
        public DbSet<Movie> Movies{ get; set; }
        public DbSet<MovieActor> MovieActor { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ShowTime> ShowTimes{ get; set; }
        public DbSet<Ticket> Tickets{ get; set; }
    }

}
