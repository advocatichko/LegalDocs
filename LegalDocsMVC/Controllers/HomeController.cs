using LegalDocsData.Context;
using LegalDocsMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LegalDocsMVC.Context;


namespace LegalDocsMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDBContext db;
        public HomeController(ApplicationDBContext dbcontext)
        {
           db = dbcontext;
        }

        public IActionResult Index()
        {
            ViewBag.Data = db.CourtDatas;
            return View();
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