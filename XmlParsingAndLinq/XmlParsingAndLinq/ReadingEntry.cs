using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlParsingAndLinq
{
    class ReadingEntry
    {
        public int Id { get; set; }
        public string Reading { get; set; }
        public string ReadingRestriction { get; set; }
        public string ReadingInformation { get; set; }
        public string ReadingPriority { get; set; }
        public bool NoKanjiReading { get; set; }
        public int EntryId { get; set; }

        public override string ToString()
        {
            return Reading;
        }
    }
}
