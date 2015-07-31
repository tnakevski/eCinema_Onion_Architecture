using eCinema.Infrastructure.DataMSSQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Infrastructure.DataMSSQL
{
    public class UnityOfWork
    {
        eCinemaDbContext _context;
        public UnityOfWork(eCinemaDbContext context)
        {
            _context = context;
        }

        private MovieRepository _movieRepo;
        private ActorRepository _actorRepo;
        private GenreRepository _genreRepo;
        private HallRepository _hallRepo;
        private RatingRepository _ratingRepo;
        private ShowTimeRepository _showTimeRepo;
        private TicketRepository _ticketRepo;
        private UserRepository _userRepo;

        public UserRepository UserRepository
        {
            get
            {
                if (_userRepo == null)
                    _userRepo = new UserRepository(_context);
                return _userRepo;
            }
        }

        public TicketRepository TicketRepository
        {
            get
            {
                if (_ticketRepo == null)
                    _ticketRepo = new TicketRepository(_context);
                return _ticketRepo;
            }
        }
        public ShowTimeRepository ShowTimeRepository
        {
            get
            {
                if (_showTimeRepo == null)
                    _showTimeRepo = new ShowTimeRepository(_context);
                return _showTimeRepo;
            }
        }

        public RatingRepository RatingRepository
        {
            get
            {
                if (_ratingRepo == null)
                    _ratingRepo = new RatingRepository(_context);
                return _ratingRepo;
            }
        }

        public HallRepository HallRepository
        {
            get
            {
                if (_hallRepo == null)
                    _hallRepo = new HallRepository(_context);
                return _hallRepo;
            }
        }
        public GenreRepository GenreRepository
        {
            get
            {
                if (_genreRepo == null)
                    _genreRepo = new GenreRepository(_context);
                return _genreRepo;
            }
        }

        public ActorRepository ActorRepository
        {
            get
            {
                if (_actorRepo == null)
                    _actorRepo = new ActorRepository(_context);
                return _actorRepo;
            }
        }
        public MovieRepository MovieRepository
        {
            get
            {
                if (_movieRepo == null)
                    _movieRepo = new MovieRepository(_context);
                return _movieRepo;
            }
        }

    }
}
