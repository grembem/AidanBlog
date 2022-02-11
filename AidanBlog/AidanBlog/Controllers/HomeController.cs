using AidanBlog.Data;
using AidanBlog.Models;
using AidanBlog.Models.HomeViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace AidanBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AidanBlogContext _context;
        public HomeController(ILogger<HomeController> logger, AidanBlogContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new HomeViewModel
            {
                Posts = await _context.Post.OrderByDescending(x => x.CreatedDate).ToListAsync()
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}