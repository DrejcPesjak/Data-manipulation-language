using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSVposte
{
    class CSVposte
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Source:
            ///https://gist.github.com/panter4/a88011601be5f5dea5e029269ced399a
            ///https://www.c-sharpcorner.com/article/how-to-upload-browse-and-show-csv-file-information-in-asp-net-gridview/
            ///</summary>
            string csvPath = "postne_stevilke.csv"; //Path.GetFileName(this);
            string csvData = File.ReadAllText(csvPath);

            //Execute a loop over the rows.  
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    string[] cell = row.Split(',');

                    Console.Write(cell[0] + "|");
                }
            }

            Console.ReadKey();
        }
    }
}
