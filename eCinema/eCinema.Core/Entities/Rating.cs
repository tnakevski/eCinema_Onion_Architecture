﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Core.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int MovieRating { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }

        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
