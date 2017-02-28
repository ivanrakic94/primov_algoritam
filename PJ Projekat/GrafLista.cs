using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PJ_Projekat
{
    class GrafLista
    {

        public LinkedList<LinkedList<Cvor>> lista = new LinkedList<LinkedList<Cvor>>();

        public GrafLista (String url)
	    {
            using (StreamReader ulaz = new StreamReader(File.OpenRead(url)))
            {

                int br = 0;
                while (!ulaz.EndOfStream)
                {
                    string red = ulaz.ReadLine();
                    string[] vr = red.Split(',');

                    lista.AddLast(new LinkedList<Cvor>());

                    for (int i = 0; i < vr.Length; i++)
                    {
                        if (!vr[i].Equals("/"))
                        {
                            lista.ElementAt(br).AddLast(new Cvor(i, Convert.ToDouble(vr[i])));
                        }
                        else
                        {
                            lista.ElementAt(br).AddLast(new Cvor(i, Double.MaxValue));
                        }

                    }
                    br++;
                }



            }
	    }  

        
    }
}
