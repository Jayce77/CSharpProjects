using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShinRin.Models
{
    public class GrammarTerm
    {
        public GrammarTerm()
        {
            GrammarMeanings = new List<GrammarMeaning>();
        }

        public int Id { get; set; }
        public string Term { get; set; }
        public NounForm NounForm { get; set; }
        public int? NounFormId { get; set; }
        public VerbForm VerbForm { get; set; }
        public int? VerbFormId { get; set; }
        public IAdjForm IAdjForm { get; set; }
        public int? IAdjFormId { get; set; }
        public NaAdjForm NaAdjForm { get; set; }
        public int NaAdjFomrId { get; set; }
        public OtherForm OtherForm { get; set; }
        public int OtherFormId { get; set; }
        public virtual ICollection<GrammarMeaning> GrammarMeanings { get; set; }


    }
}