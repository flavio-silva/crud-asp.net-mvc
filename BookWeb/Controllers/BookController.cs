﻿using BookWeb.DAO;
using BookWeb.Models;
using System.Web.Mvc;

namespace BookWeb.Controllers
{
    public class BookController : Controller
    {
        
        public ActionResult Index()
        {
            var dao = new BookDAO();
            ViewBag.Books = dao.All();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Store(Book book)
        {
            var dao = new BookDAO();
            dao.Create(book);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var dao = new BookDAO();

            ViewBag.Book = dao.Find(id);
            return View();
        }

        public ActionResult Update(Book book)
        {
            var dao = new BookDAO();
            dao.Update(book);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var dao = new BookDAO();
            dao.Delete(id);
            return RedirectToAction("Index");
        }
    }
}