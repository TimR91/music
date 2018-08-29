using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZZTop.Data;
using ZZTop.Models;


namespace ZZTop.Controllers

{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Songs.Where(m=>m.IsFeatured == true).ToList()); //searches through all the songs and displays featured songs on carousel in home page with price
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Albums()
        {
            return View(_context.Songs.GroupBy(x => x.Album).Select(grp => grp.First()).ToList());
            //                                                                       confused about to LIST
        }
        public IActionResult Songs()
        {
            return View(_context.Songs.Where(x => x.IsActive == true).ToList());
        }
    }
}
