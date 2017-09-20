using ShinRin.Models;
using ShinRin.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShinRin.Controllers
{
    public class WordFormsController : Controller
    {
        private ApplicationDbContext _context;

        public WordFormsController()
        {
            _context = new ApplicationDbContext();
        }
        
        // GET: WordForms
        public ActionResult Index()
        {
            var wordForms = new WordForms
            {
                VerbForms = _context.VerbForms.ToList(),
                NounForms = _context.NounForms.ToList(),
                IAdjForms = _context.IAdjForms.ToList(),
                OtherForms = _context.OtherForms.ToList()
            };


            return View();
        }

        // GET: WordForms/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WordForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WordForms/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WordForms/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WordForms/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WordForms/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WordForms/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
