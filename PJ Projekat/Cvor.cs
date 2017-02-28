using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJ_Projekat
{
    class Cvor
    {
        private int sused;

        private double grana;

        public Cvor(int c, double g)
        {
            sused = c;
            grana = g;
        }

        public double Grana
        {
            get { return grana; }
            set { grana = value; }
        }

        public int Sused
        {
            get { return sused; }
            set { sused = value; }
        }
        

    }
}
