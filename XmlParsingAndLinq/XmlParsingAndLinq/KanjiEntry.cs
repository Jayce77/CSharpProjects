using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlParsingAndLinq
{
    class KanjiEntry
    {
        public int Id { get; set; }
        public string Kanji { get; set; }
        public string KanjiInformation { get; set; }
        public string KanjiPriority { get; set; }
        public int EntryId { get; set; }

        public override string ToString()
        {
            return Kanji;
        }
    }
}
