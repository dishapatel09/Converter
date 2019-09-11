using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace XmlToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("https://www.w3schools.com/xml/note.xml");

            string json = JsonConvert.SerializeXmlNode(xmlDocument);
            Console.WriteLine(json);

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "test.json")))
            {
               
                    outputFile.WriteLine(json);
            }
        }
    }
}
