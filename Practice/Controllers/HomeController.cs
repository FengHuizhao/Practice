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
        private INoteServices _noteServices;
     
        public HomeController(ILogger<HomeController> logger, INoteServices noteServices)
        {
            _logger = logger;
            _noteServices = noteServices;
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

        [HttpGet]
        // return NoteEditor view
        public IActionResult NoteEditor(Note note)
        {   
            if (note != null)
            {
                return View(note);
            }

            return View();
        }

        [HttpPost]
        // 1.Save note  2. redirect to NoteList
        public IActionResult EditNote(Note note)
        {

            if (note != null)
            {
              _noteServices.AddNote(note);
            }

            return RedirectToAction("NoteList");

        }

        public IActionResult NoteDetail(Guid id)
        {
            Note note = _noteServices.FindNoteById(id);
            return View(note);
        }

        public IActionResult NoteList()
        {
            IEnumerable<Note> notes = _noteServices.GetAllNotes();

            return View(notes);
        }

        public IActionResult DeleteNote(Guid id)
        {
            var note = _noteServices.FindNoteById(id);

            _noteServices.DeleteNote(note);
            note.IsDeleted = true;
            return RedirectToAction("NoteList");
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
