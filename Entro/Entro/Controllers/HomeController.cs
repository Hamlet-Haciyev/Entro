using Entro.DataDB;
using Entro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entro.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Entro.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            ViewBag.Name = "Home";
            //About about = _appDbContext.Abouts.FirstOrDefault();
            //Concert concert = _appDbContext.Concerts.FirstOrDefault();
            //Setting setting = _appDbContext.Settings.FirstOrDefault();
            //List<Social> social = _appDbContext.Socials.ToList();
            //ViewBag.sc = social;

            HomeRelated homeRelated = new HomeRelated();
            homeRelated.about = _appDbContext.Abouts.FirstOrDefault();
            homeRelated.concert = _appDbContext.Concerts.FirstOrDefault();
            homeRelated.setting = _appDbContext.Settings.FirstOrDefault();
            homeRelated.slider = _appDbContext.Sliders.FirstOrDefault();
            homeRelated.gallery = _appDbContext.Galeries.Include(n=>n.GaleryImages).ToList();
            homeRelated.socials = _appDbContext.Socials.ToList();

            //var tuple = (about,concert);

            return View(homeRelated);
        }

     
    }
}
