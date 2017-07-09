using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XmlParsingAndLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadWords();
        }

        private void LoadWords()
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\That Guy\Documents\JMdict\JMdict_e.xml");

            XDocument xdoc = XDocument.Load(@"C:\Users\That Guy\Documents\JMdict\JMdict_e.xml");
            xdoc.Descendants("entry").Select( p => new Entry {
                Id = int.Parse(p.Element("ent_seq").Value),
                Readings = p.Descendants("r_ele").Select(n => new ReadingEntry
                {

                    Reading = n.Elements("reb").Any() ? n.Element("reb").Value : "",
                    ReadingRestriction = n.Elements("re_restr").Any() ? n.Element("re_restr").Value : "",
                    ReadingInformation = n.Elements("re_inf").Any() ? n.Element("re_inf").Value : "",
                    ReadingPriority = n.Elements("re_pri").Any() ? n.Element("re_pri").Value : "",
                    NoKanjiReading = n.Elements("re_pri").Any() ? true : false,
                    EntryId = int.Parse(p.Element("ent_seq").Value)
                }).ToList()
            }).ToList().ForEach(p => {
                Console.WriteLine("Id: " + p.Id);
                foreach (var name in p.Readings)
                {
                    Console.WriteLine(name.Reading);
                }
                Console.WriteLine("========================");
                if (p.Id == 1013730)
                {
                    Entry foundOne = p;
                    listBox1.Items.Add(foundOne);
                }
            });
            Console.ReadLine();

            //foreach (XmlNode node in document.DocumentElement)
            //{
                
            //    Word word = new Word();
            //    word.Id = int.Parse(node["ent_seq"].InnerText);
            //    //word.Name = node.Attributes[1][0].InnerText;
            //    if (node["sense"]["gloss"].InnerText != null)
            //    {
            //        word.Meaning = node["sense"]["gloss"].InnerText;
            //    }
            //    listBox1.Items.Add(word);
            //    counter++;
            //    if (counter > 15)
            //    {
            //        break;
            //    }
            //}
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }
    }
}
