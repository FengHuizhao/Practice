using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice.Models;
using Practice.Services;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductServices productServices = new ProductServices();
        private NumberServices numberServices = new NumberServices();
        private SelectServices selectServices = new SelectServices();
        private NoteServices noteServices = new NoteServices();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            Product product = productServices.getProductDetail();
            return View(product);
        }

        public IActionResult Number(string inputNumber = null)
        {
            if (String.IsNullOrEmpty(inputNumber))
            {
                inputNumber = "0";
            }
            Number number = numberServices.createNumber(inputNumber);
            return View(number);
        }

        public IActionResult Select (string inputSelect = null)
        {
            if (String.IsNullOrEmpty(inputSelect))
            {
                inputSelect = "";
            }
            Select select = selectServices.chooseProduct(inputSelect);
            return View(select);
        }

        public IActionResult Note(string inputSubject = null, string inputContent = null)
        {
            if (String.IsNullOrEmpty(inputSubject))
            {
                inputSubject = "";
                inputContent = "";
            }
            Note note = noteServices.createNote(inputSubject, inputContent);
            return View(note);
        }

        public IActionResult NoteDetail(string inputSubject, string inputContent)
        {
            Note note = new Note(inputSubject, inputContent);
            return View(note);
        }

        public IActionResult NoteList(string inputSubject, string inputContent)
        {
            Note note = new Note(inputSubject, inputContent);
            return View(note);
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
