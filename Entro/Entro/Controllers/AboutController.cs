using Entro.DataDB;
using Entro.Models;
using Entro.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public AboutController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            HomeRelated homeRelated = new HomeRelated();
            homeRelated.about = _appDbContext.Abouts.FirstOrDefault();
            homeRelated.socials = _appDbContext.Socials.ToList();
            homeRelated.setting = _appDbContext.Settings.FirstOrDefault();

            return View(homeRelated);
        }
    }
}
