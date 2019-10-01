using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DoWhile_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string secim;

            do
            {
                Console.WriteLine("1- Para çek\n2- Bakiye görüntüle\n3- Çıkış yap\nTerchiniz: ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Hiç paranız yok lol!");
                        break;

                    case "2":
                        Console.WriteLine("0 liranız var lmao!");
                        break;

                    case "3":
                        Console.WriteLine("Çıkış yapıldı.");
                        break;

                    default:
                        Console.WriteLine("1-2-3 den birini seçin");
                        break;
                }
            } while (secim != "3");
            {

            }

            Console.ReadLine();
        }
    }
}
