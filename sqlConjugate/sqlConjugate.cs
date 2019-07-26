using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlConjugate
{
    class sqlConjugate
    {
        static void Main(string[] args)
        {
            string csvPath = "termini.csv";
            string csvDataTermin = File.ReadAllText(csvPath).Replace("\r","");
            string csvVpis = File.ReadAllText("vpisi.csv");
            string[] vpisi = csvVpis.Split('\n');
            string SQLquery = "INSERT INTO [dbo].[Termin]([datum],[EMSO_pacienta],[EMSO_doktorja],[opis]) \nVALUES";

            
            int i = 0;
            foreach (string row in csvDataTermin.Split('\n'))
            {
                string[] cell = row.Split(',');

                string vrstica = "('" + cell[0] + "','" + cell[1] + "','" + cell[2] + "','" + vpisi[i].Replace("\r", "").Replace("\"","").TrimStart(' ') + "'),\n";
                SQLquery += vrstica;
                if (i < vpisi.Length-2) i++;
                else i = 0;
            }

            Console.Write(SQLquery);

            Console.ReadKey();
        }
    }
}
