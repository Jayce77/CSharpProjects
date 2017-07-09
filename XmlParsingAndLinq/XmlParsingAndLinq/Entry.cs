using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlParsingAndLinq
{
    class Entry
    {
        public int Id { get; set; }
        public List<ReadingEntry> Readings { get; set; }
        public string Meaning { get; set; }

        public override string ToString()
        {
            string names = "";
            foreach (var name in Readings)
            {
                names += name.ToString() + " ";
            }
            return Id.ToString() + " " + names;
        }
    }
}
