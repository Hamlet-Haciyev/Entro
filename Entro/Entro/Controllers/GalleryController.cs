using Entro.DataDB;
using Entro.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class GalleryController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public GalleryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            HomeRelated homeRelated = new HomeRelated();
            homeRelated.gallery = _appDbContext.Galeries.Include(n => n.GaleryImages).ToList();
            homeRelated.socials = _appDbContext.Socials.ToList();
            homeRelated.setting = _appDbContext.Settings.FirstOrDefault();

            return View(homeRelated);
        }
    }
}
