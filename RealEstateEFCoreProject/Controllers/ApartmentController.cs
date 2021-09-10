using Microsoft.AspNetCore.Mvc;
using RealEstateEFCoreProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateEFCoreProject.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly DataContext _context;

        public ApartmentController (DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var apartments = _context.Apartments.ToList();
            return View(apartments);
        }
    }
}
