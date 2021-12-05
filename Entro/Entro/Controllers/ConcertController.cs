using Entro.DataDB;
using Entro.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class ConcertController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ConcertController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            HomeRelated homeRelated = new HomeRelated();
            homeRelated.concert = _appDbContext.Concerts.FirstOrDefault();
            homeRelated.socials = _appDbContext.Socials.ToList();
            homeRelated.setting = _appDbContext.Settings.FirstOrDefault();

            return View(homeRelated);
        }
    }
}
