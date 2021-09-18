using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateEFCoreProject.Data;
using RealEstateEFCoreProject.Dtos;
using RealEstateEFCoreProject.Models;
using System;
using System.Collections.Generic;
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
            var brokerIndex = new List<BrokerIndexDto>();
            var brokers = _context.Brokers.Include(b => b.CompanyBrokers).ThenInclude(c => c.Company).ToList();
            foreach (var broker in brokers)
            {
                var companyName = broker.CompanyBrokers.Select(c => c.Company).Select(c => c.CompanyName);
                brokerIndex.Add(new BrokerIndexDto()
                {
                    Broker = broker,
                    CompanyNames = String.Join(", ", companyName)
                });
            }
            return View(brokerIndex);
        }
        public IActionResult Add()
        {
            var broker = new BrokerCreate()
            {
                Companies = _context.Companies.ToList()
            };
            return View(broker);
        }
        [HttpPost]
        public IActionResult Add(BrokerCreate brokerCreate)
        {
            var broker = new BrokerModel()
            {
                Name = brokerCreate.Broker.Name,
                Surname = brokerCreate.Broker.Surname,
            };
            _context.Brokers.Add(broker);

            var companyBroker = new List<CompanyBroker>();
            if (brokerCreate.CompanyIds != null)
            {
                foreach (var companyId in brokerCreate.CompanyIds)
                {
                    _context.CompanyBrokers.Add(new CompanyBroker()
                    {
                        Broker = broker,
                        CompanyId = companyId
                    });
                }

            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var brokerCreate = new BrokerCreate();
            brokerCreate.Broker = _context.Brokers.FirstOrDefault(s => s.Id == id);
            brokerCreate.Companies = _context.Companies.ToList();

            return View(brokerCreate);
        }
        [HttpPost]
        public IActionResult Edit(BrokerCreate brokerCreate)
        {
            var tmpRng = _context.CompanyBrokers.Where(b => b.BrokerId == brokerCreate.Broker.Id);
            _context.CompanyBrokers.RemoveRange(tmpRng);
            if (brokerCreate.CompanyIds != null)
            {
                foreach (var companyId in brokerCreate.CompanyIds)
                {
                    var companyBroker = new CompanyBroker()
                    {
                        Broker = brokerCreate.Broker,
                        CompanyId = companyId
                    };
                    _context.CompanyBrokers.Add(companyBroker);
                }
            }
            _context.Brokers.Update(brokerCreate.Broker);
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
