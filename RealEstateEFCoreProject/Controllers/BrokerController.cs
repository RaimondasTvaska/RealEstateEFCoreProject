using Microsoft.AspNetCore.Mvc;
using RealEstateEFCoreProject.Data;
using RealEstateEFCoreProject.Models;
using System.Linq;

namespace RealEstateEFCoreProject.Controllers
{
    public class BrokerController : Controller
    {
        private readonly DataContext _context;

        public BrokerController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var brokers = _context.Brokers.ToList();
            return View(brokers);
        }
        public IActionResult Add()
        {
            var broker = new BrokerModel();
            return View(broker);
        }
        [HttpPost]
        public IActionResult Add(BrokerModel broker)
        {
            _context.Brokers.Add(broker);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
