using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShinRin.Models
{
    public class GrammarGroup
    {
        public GrammarGroup()
        {
            new List<GrammarTerm>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<GrammarTerm> GrammarTerms { get; set; }
    }
}