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
            xdoc.Descendants("entry").Select( p => new {
                id = p.Element("ent_seq").Value
            }).ToList().ForEach(p => {
                Console.WriteLine("Id: " + p.id);
            });

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
