using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileImena
{
    class fileImena
    {
        static void Main(string[] args)
        {
            using (StreamReader strReader = new StreamReader("imena-moski.txt"))
            {
                string urejen_text = "";
                while (!strReader.EndOfStream)
                {
                    string vrstica = strReader.ReadLine();
                    if (vrstica.Length > 1)
                    {
                        if (vrstica.Contains('('))
                        {
                            int razlika = vrstica.IndexOf(')') - vrstica.IndexOf('(');
                            vrstica = vrstica.Remove(vrstica.IndexOf('('), razlika+1);
                        }
                        urejen_text += vrstica + ',';
                    }

                }

                Console.WriteLine(urejen_text);

                Console.ReadKey();
            }
        }
    }
}
