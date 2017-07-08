using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            var webGet = new HtmlWeb();
            HtmlDocument doc = webGet.Load("http://www.politico.com/magazine/story/2017/07/07/trump-handed-putin-a-stunning-victory-215353");
            Console.WriteLine(doc);
        }
    }
}
