using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoremIpsum
{
    class LoremIpsum
    {
        static void Main(string[] args)
        {
            using (StreamReader strReader = new StreamReader("loremIpsumCSV.txt"))
            {
                string loremtext = "";

                while (!strReader.EndOfStream)
                {
                    //bool stolpec = true;
                    string vrstica = strReader.ReadLine();
                    vrstica = vrstica.Replace('\"', ' ');

                    vrstica = '\'' + vrstica.Insert(vrstica.LastIndexOf(','), "\'");

                    loremtext += '(' + vrstica + "),\n";
                }

                Console.WriteLine(loremtext);//.Replace('\"', ' '));
            }

            Console.ReadKey();
        }
    }
}
