using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace pr_32_prakt15_4_OAP_Kolyasnikova.V
{
    class Program
    {
        public struct People
        {
            public string familia;
            public string imya;
            public string otchestvo;
            public int vozrast;
            public int ves;
        }
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("t.txt");
            People v;
            string st;
            Queue q = new Queue();
            Console.WriteLine("Младше 40 лет");
            while ((st = f.ReadLine()) != null) 
            {
                string[ ] s = st.Split();
                v.familia = s[0];
                v.imya = s[1];
                v.otchestvo = s[2];
                v.vozrast = Convert.ToInt32(s[3]);
                v.ves = Convert.ToInt32(s[4]);
                if (v.vozrast < 40)
                {
                    Console.WriteLine(v.familia + " " + v.imya + " " + v.otchestvo + " " + v.vozrast + " " + v.ves);
                }
                else
                {
                    q.Enqueue(v);
                }
            }
            f.Close();
            Console.WriteLine("Старше 40 лет");
            while (q.Count != 0)
            {
                v = (People)q.Dequeue();
                Console.WriteLine(v.familia + " " + v.imya + " " + v.otchestvo + " " + v.vozrast + " " + v.ves);
            }
            Console.ReadKey();
        }
    }
}
