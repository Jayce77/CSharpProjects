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
                NaAdjForms = _context.NaAdjForms.ToList(),
                OtherForms = _context.OtherForms.ToList()
            };


            return View(wordForms);
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
