using eCinema.Infrastructure.AppServices.DTOs;
using eCinema.Infrastructure.AppServices.Services;
using eCinema.Infrastructure.DataMSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCinema.WebApp.Controllers
{
    public class AccountController : Controller
    {
        AccountService _accService;
        public AccountController()
        {
            eCinemaDbContext context = new eCinemaDbContext();
            _accService = new AccountService(context);
        }
        //
        // GET: /Account/

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDto dto)
        {
            ViewBag.ErrorMessage = null;
            if (_accService.Login(dto))
            {
                Session["User"] = dto;
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Username or password are not valid";        
            return View(dto);
        }
	}
}