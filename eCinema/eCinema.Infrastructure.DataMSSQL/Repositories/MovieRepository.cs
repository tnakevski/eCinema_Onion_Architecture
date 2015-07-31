﻿using eCinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Infrastructure.DataMSSQL.Repositories
{
    public class MovieRepository : BaseRepository<Movie>
    {
        public MovieRepository(eCinemaDbContext context)
            : base(context)
        {


        }
    }
}