using ShinRin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShinRin.Controllers
{
    public class GrammarController : Controller
    {
        // GET: Grammar
        public ActionResult Index()
        {
            var grammarTerm = GetGrammarTerm();
            return View(grammarTerm);
        }

        private GrammarTerm GetGrammarTerm()
        {
            return new GrammarTerm
            {
                Id = 1,
                Term = "ことに",
                NounForm = new NounForm { Id = 1, Name = "N"},
                VerbForm = new VerbForm { Id = 1, Name = "V"},
                OtherForm = new OtherForm { Id = 1, Name = "数量詞"}
            };
        }

    }
}