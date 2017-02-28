using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace PJ_Projekat
{
    class PrimovAlgoritam
    {
        static int[] n;
        static Grana[] l;

        static GrafMatrica grafM = new GrafMatrica(@ConfigurationManager.AppSettings["putanjaDoFajla"]);
        static GrafLista grafL = new GrafLista(@ConfigurationManager.AppSettings["putanjaDoFajla"]);

        public static void Main(String[] args)
        {
            n = new int[grafM.d];
            l = new Grana[grafM.d - 1];

          //  algoritamMatrica();
            algoritamLista();

            for (int i = 0; i < grafM.d - 1; i++)
            {
                
                Console.Write(l[i].Cvor1 +1);
                Console.WriteLine(l[i].Cvor2 +1);

            }
        }

        public static void algoritamMatrica()
        {
            var sat = System.Diagnostics.Stopwatch.StartNew();
            n[0] = 0;
            int k = 1;
            for (int i = 0; i < grafM.matricaRastojanja.GetLength(0)-1; i++)
            {
                LinkedList<Grana> m = new LinkedList<Grana>();
                for (int j = 0; j < k; j++)
                {
                    for (int z = 0; z < grafM.matricaRastojanja.GetLength(0); z++)
                    {
                        if (z != n[j] && grafM.matricaRastojanja[n[j], z] != Double.MaxValue && !n.Contains(z))
                        {
                            m.AddLast(new Grana(n[j], z, grafM.matricaRastojanja[n[j], z]));
                        }
                    }
                }

                Grana min = m.ElementAt(0);
                foreach (Grana g in m)
                {
                    if (g.Vrednost < min.Vrednost)
                    {
                        min = g;
                    }
                }

                if (n.Contains(min.Cvor1))
                {
                    n[i + 1] = min.Cvor2;
                }
                else
                {
                    n[i + 1] = min.Cvor1;
                }
                l[i] = min;
                k++;
            }
            sat.Stop();
            Console.WriteLine("Vreme izvršenja: "+sat.Elapsed);
        }

        public static void algoritamLista()
        {
            var sat = System.Diagnostics.Stopwatch.StartNew();
            n[0] = 0;
            int k = 1;

            for (int i = 0; i < grafL.lista.Count-1; i++)
            {
                LinkedList<Grana> m = new LinkedList<Grana>();
                for (int j = 0; j < k; j++)
                {
                    foreach (Cvor z in grafL.lista.ElementAt(n[j]))
                    {
                        if (!n.Contains(z.Sused))
                        {
                           m.AddLast(new Grana(n[j], z.Sused, z.Grana));
                        }
                    }
                }
                Grana min = m.ElementAt(0);
                foreach (Grana g in m)
                {
                    if (g.Vrednost < min.Vrednost)
                    {
                        min = g;
                    }
                }

                if (n.Contains(min.Cvor1))
                {
                    n[i + 1] = min.Cvor2;
                }
                else
                {
                    n[i + 1] = min.Cvor1;
                }
                l[i] = min;
                k++;
            }
            sat.Stop();
            Console.WriteLine("Vreme izvršenja: " + sat.Elapsed);
        }

    }
}
