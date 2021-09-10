using Microsoft.AspNetCore.Mvc;
using RealEstateEFCoreProject.Data;
using RealEstateEFCoreProject.Models;
using System.Linq;

namespace RealEstateEFCoreProject.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly DataContext _context;

        public ApartmentController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var apartments = _context.Apartments.ToList();
            return View(apartments);
        }
        public IActionResult Add()
        {
            var apartment = new ApartmentModel();
            return View(apartment);
        }

        [HttpPost]
        public IActionResult Add(ApartmentModel apartment)
        {
            _context.Apartments.Add(apartment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
