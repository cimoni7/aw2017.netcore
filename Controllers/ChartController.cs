using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AW2017.Models;
using AW2017.Data;
using Kendo.Mvc.UI;

namespace AW2017.Controllers
{
    public class ChartController : Controller
    {
        private readonly ILogger<ChartController> _logger;
        private readonly ApplicationDbContext _db;

        public ChartController(ILogger<ChartController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<Sale> salesList = _db.Sales.ToList();

            return View(salesList);
        }
    }
}
