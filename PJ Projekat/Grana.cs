using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PJ_Projekat
{
    class Grana
    {
        private int cvor1;
        private int cvor2;
        private double vrednost;

        public Grana(int cv1, int cv2, double vr)
        {
            cvor1 = cv1;
            cvor2 = cv2;
            vrednost = vr;
        }

        public int Cvor1
        {
            get { return cvor1; }
            set { cvor1 = value; }
        }

        public int Cvor2
        {
            get { return cvor2; }
            set { cvor2 = value; }
        }


        public double Vrednost
        {
            get { return vrednost; }
            set { vrednost = value; }
        }
        

    }
}
