using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CET322Assignment2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CET322Assignment2.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            FakeDB fakeDB = new FakeDB();
            var allbooks = fakeDB.GetAllBooks();

            return View(allbooks);
        }

        public IActionResult Detail(int? id)
        {
            if (!id.HasValue) return BadRequest();

            FakeDB db = new FakeDB();
            var book = db.GetBookById(id.Value);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = FakeDB.Db.Any() ? FakeDB.Db.Max(b => b.Id) + 1 : 1;
                FakeDB.Db.Add(book);
                return RedirectToAction("Index");
            }

            return View(book);
        }

        public IActionResult Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();

            FakeDB db = new FakeDB();
            var result = db.DeleteBook(id.Value);

            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }
    }
}

