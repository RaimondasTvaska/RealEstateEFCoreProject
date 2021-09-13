using Microsoft.AspNetCore.Mvc;
using RealEstateEFCoreProject.Data;
using RealEstateEFCoreProject.Models;
using System.Linq;

namespace RealEstateEFCoreProject.Controllers
{
    public class CompanyController : Controller
    {
        private readonly DataContext _context;

        public CompanyController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var companies = _context.Companies.ToList();

            return View(companies);
        }
        public IActionResult Add()
        {
            var company = new CompanyModel();
            company.Brokers = _context.Brokers.ToList();
            return View(company);
        }
        [HttpPost]
        public IActionResult Add(CompanyModel company)
        {
            if (company.BrokerIds != null)
            {
                company.Brokers = _context.Brokers.Where(b => company.BrokerIds.Contains(b.Id)).ToList();
            }
            _context.Companies.Add(company);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var company = _context.Companies.FirstOrDefault(s => s.Id == id);

            return View(company);
        }
        [HttpPost]
        public IActionResult Edit(CompanyModel company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
