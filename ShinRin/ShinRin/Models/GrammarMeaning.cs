using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShinRin.Models
{
    public class GrammarMeaning
    {
        public int Id { get; set; }
        public string Meaning { get; set; }
        public virtual GrammarTerm GrammarTerm { get; set; }
    }
}