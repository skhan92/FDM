using ASPAdvancedDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPAdvancedDemo.Controllers
{
    public class BooksController : Controller
    {
        BookDbContext db = new BookDbContext();

        // GET: Books
        public ActionResult Index()
        {
            return View("Index", db.books.ToList()); //passing the view some data - model
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book bookToAdd)
        {
            db.books.Add(bookToAdd);
            db.SaveChanges();
            
            if (Request.IsAjaxRequest())
            {
                return PartialView("_success");
            }
            else
            {
                return RedirectToAction("Index");
            }

            //return RedirectToAction("Index"); //TAKES BACK TO HOMEPAGE
        }
    }
}