using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task.Controllers
{
    public class HomeController:Controller
    {
        private readonly AddDbContext _context;

        public HomeController(AddDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
