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
        public ActionResult Index()
        {
            var GrammarTerms = GetGrammarTermList();
            return View(GrammarTerms);
        }
        
        // GET: Grammar
        public ActionResult GrammarGroupDetails()
        {
            var grammarGroup = GetGrammarGroup();
            return View(grammarGroup);
        }

        private GrammarGroup GetGrammarGroup()
        {
            return new GrammarGroup
            {

                Id = 1,
                Name = "KotoniTabiniOkini",

                GrammarTerms = GetGrammarTermList()
            };
        }

        private List<GrammarTerm> GetGrammarTermList()
        {
            var GrammarTerms = new List<GrammarTerm>
            {
                new GrammarTerm
                {
                    Id = 1,
                    Term = "ことに",
                    NounForm = new NounForm { Id = 1, Name = "N" },
                    VerbForm = new VerbForm { Id = 1, Name = "V" },
                    OtherForm = new OtherForm { Id = 1, Name = "数量詞" }
                },
                new GrammarTerm
                {
                    Id = 2,
                    Term = "たびに",
                    NounForm = new NounForm { Id = 1, Name = "N" },
                    VerbForm = new VerbForm { Id = 1, Name = "V" }
                },
                new GrammarTerm
                {
                    Id = 3,
                    Term = "おきに",
                    OtherForm = new OtherForm { Id = 1, Name = "数量詞" }
                }
            };

            return GrammarTerms;
        }

    }

}