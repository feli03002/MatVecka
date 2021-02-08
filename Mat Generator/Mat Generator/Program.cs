using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mat_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // poopoopeepeetime

            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "..\\..\\Properties\\Resources\\Recept.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList xnList = doc.SelectNodes("/mat/recept [@Type=")            

        }
    }
}
