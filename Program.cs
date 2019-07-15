using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication44
{
    class Program
    {
        static int enbuyuk(int[] x)
        {
            int enb = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > enb)
                    enb = x[i];
            }

            return enb;
        }


        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 8, 35, 21, 16, 8 };
            Console.WriteLine(enbuyuk(a));

        }
    }
}
