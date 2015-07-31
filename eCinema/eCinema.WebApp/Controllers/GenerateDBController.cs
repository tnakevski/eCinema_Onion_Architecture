using eCinema.Infrastructure.AppServices.Services;
using eCinema.Infrastructure.DataMSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCinema.WebApp.Controllers
{
    public class GenerateDBController : Controller
    {
        //
        // GET: /GenerateDB/
        GenerateDBService _dbService;
        public GenerateDBController()
        {
            eCinemaDbContext _context = new eCinemaDbContext();
            _dbService = new GenerateDBService(_context);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListMovies()
        {
            var movies = _dbService.GenerateDB();
            return View(movies);
        }
	}
}