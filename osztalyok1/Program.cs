using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok1
{
    public class butorlap
    {
        private int tartolapar = 5000;
        private int hatlapar = 500;

        public butorlap(int tartolapar,int hatlapar)
        {
            tartolapar = 5000;
            hatlapar = 500;
        }
        public butorlap(string tipus,int hosszusag,int szelesseg)
        {
            Console.WriteLine();
        }

        public int tartolap
        {
            get { return tartolap; }
            set { tartolapar = value; }
        }

        public int hatlap
        {
            get { return hatlap; }
            set { hatlapar = value; }
        }
        public void arSzamol()
        {
            int ar = 0;
            if (tipus == "tartólap")
            {
                ar = 5000 * hosszusag * szelesseg;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a butor tipusát (tartolap,hatlap):");
        }
    }
}
