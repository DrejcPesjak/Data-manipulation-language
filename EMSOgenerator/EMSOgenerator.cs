using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSOgenerator
{
    class EMSOgenerator
    {
        static void Main(string[] args)
        {
            string[] emsi = new string[100];

            /*for (int i = 0; i < 10; i++)
            {
                Console.Write("Datum: ");
                string dat = Console.ReadLine();
                Console.Write("spol črka: ");
                char spol = Console.ReadLine()[0];

                string[] s = dat.Split('.');
                emsi[i] = EMSOgenerator.EMSO(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), spol);
            }*/
            
            for (int i = 0; i < 100; i++)
            {
                Random rnd = new Random(i);
                DateTime date = RandomDay(rnd);
                char[] spol = new char[2] { 'M', 'Z' };

                emsi[i] = EMSOgenerator.EMSO(date.Day, date.Month, date.Year, spol[rnd.Next(0,1)]);

                /*if(i==50)
                {
                    string s = "";
                }*/
            }

            foreach (string s in emsi)
            {
                Console.Write("" + s.Substring(0,13) + "|");
            }
        }

        private static DateTime RandomDay(Random gen)
        {
            /// <summar>
            /// https://stackoverflow.com/questions/194863/random-date-in-c-sharp
            /// </summary>

            DateTime start = new DateTime(1975, 1, 1);
            DateTime end = new DateTime(2000, 1, 1);
            //Random gen = new Random();
            int range = ((TimeSpan)(end - start)).Days;
            return start.AddDays(gen.Next(range));
        }

        public static String EMSO(int dan, int mesec, int leto, char spol)
        {
            /// <summary>
            /// Source:
            /// https://www.delphi.si/viewtopic.php?t=9373
            /// </summary>


            String EMSO = "";
            String temp;

            if (dan <= 9)
                EMSO += "0" + dan;
            else
                EMSO += dan;

            if (mesec <= 9)
                EMSO += "0" + mesec;
            else
                EMSO += mesec;
            temp = "";
            temp += leto;

            EMSO += temp.Substring(1, 3);
            EMSO += 50;


            int r = 0;
            Random rnd = new Random();
            if ((spol == 'M') || (spol == 'm'))
            {
                r = (int)((rnd.NextDouble() * 399) + 100);
            }
            else
                r = (int)((rnd.NextDouble() * 500) + 499);

            EMSO += r;

            r = 0;

            r = ((7 * (int)EMSO[0]) + (6 * (int)EMSO[1]) + (5 * (int)EMSO[2]) + (4 * (int)EMSO[3]) + (3 * (int)EMSO[4])) + (2 * (int)EMSO[5]) + (7 * (int)EMSO[6]) + (6 * (int)EMSO[7]) + (5 * (int)EMSO[8]) + (4 * (int)EMSO[9]) + (3 * (int)EMSO[10]) + (2 * (int)EMSO[11]);
            r = r % 11;

            if (r > 0)
                r = 11 - r;

            EMSO += r;


            return EMSO;
        }
    }
}
