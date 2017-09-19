using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShinRin.Enum
{
    public enum WordForm
    {
        [Display(Name="I-Adjentive")]
        IADJFORM,

        [Display(Name = "Na-Adjentive")]
        NAADJFORM,

        [Display(Name = "Noun")]
        NOUNFORM,

        [Display(Name = "Other")]
        OTHERFORM,

        [Display(Name = "Verb")]
        VERBFORM
    }
}