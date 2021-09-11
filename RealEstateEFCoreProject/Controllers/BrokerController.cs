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
            var broker = new BrokerCreate();
            return View(broker);
        }
        [HttpPost]
        public IActionResult Add(BrokerCreate brokerCreate)
        {
            _context.Brokers.Add(brokerCreate);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var broker = _context.Brokers.FirstOrDefault(s => s.Id == id);

            return View(broker);
        }
        [HttpPost]
        public IActionResult Edit(BrokerModel broker)
        {
            _context.Brokers.Update(broker);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var broker = _context.Brokers.FirstOrDefault(s => s.Id == id);
            _context.Remove(broker);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
