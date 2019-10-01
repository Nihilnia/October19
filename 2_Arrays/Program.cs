using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ogrNo = new int[20];
            for (int i = 0; i < ogrNo.Length; i++)
            {
                ogrNo[i] = i + 1;
            }

            for (int i = 0; i < ogrNo.Length; i++)
            {
                Console.WriteLine("Ogr no: " + ogrNo[i]);
            }

            Console.Read();
        }
    }
}
