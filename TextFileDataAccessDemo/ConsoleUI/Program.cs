using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string japaneseText = "お願いします";
            string filePath = @"C:\Users\That Guy\Documents\JMdict\JMdict_e.xml";
            string newFilePath = @"C:\Users\That Guy\Documents\JMdict\japanese.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            File.WriteAllText(newFilePath, japaneseText);
            Console.ReadLine();
        }
    }
}
