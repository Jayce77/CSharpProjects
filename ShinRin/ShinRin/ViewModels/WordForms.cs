using ShinRin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShinRin.ViewModels
{
    public class WordForms
    {
        public IEnumerable<VerbForm> VerbForms { get; set; }

        public IEnumerable<NounForm> NounForms { get; set; }

        public IEnumerable<IAdjForm> IAdjForms { get; set; }

        public IEnumerable<NaAdjForm> NaAdjForms { get; set; }

        public IEnumerable<OtherForm> OtherForms { get; set; }

        public VerbForm VerbForm { get; set; }

        public NounForm NounForm { get; set; }

        public IAdjForm IAdjForm { get; set; }

        public NaAdjForm NaAdjForm { get; set; }

        public OtherForm OtherForm { get; set; }
    }
}