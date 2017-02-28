using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PJ_Projekat
{
    class GrafMatrica
    {
        public double[ , ] matricaRastojanja;
        public int d;

        public GrafMatrica(String url)
        {
            using (StreamReader ulaz = new StreamReader(File.OpenRead(url)))
            {

            string red = ulaz.ReadLine();
            string[] vr = red.Split(',');
            d = vr.Length;
            matricaRastojanja = new double[d, d];

            for (int i = 0; i < vr.Length; i++)
            {
                if (!vr[i].Equals("/"))
                {
                    matricaRastojanja[0, i] = Convert.ToDouble(vr[i]);
                }
                else
                {
                    matricaRastojanja[0, i] = Double.MaxValue;
                }
            }

            int br = 1;
            while (!ulaz.EndOfStream)
            {
                string r = ulaz.ReadLine();
                string[] v = r.Split(',');

                for (int i = 0; i < v.Length; i++)
                {
                    if (!v[i].Equals("/"))
                    {
                        matricaRastojanja[br, i] = Convert.ToDouble(v[i]);
                    }
                    else
                    {
                        matricaRastojanja[br, i] = Double.MaxValue;
                    }
                }

                br++;
            }

        } 
     
        } 

    }
}
