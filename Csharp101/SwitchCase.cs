using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp101
{
    public class SwitchCase
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            //experssion
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasın ");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasın");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasın");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayındasın");
                    break;
                default:
                    Console.WriteLine("Yanlış Veri Girişi");
                    break;

            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Aylarındasınız ");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkBahrar Aylarındasınız ");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Aylarındasınız ");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Aylarındasınız ");
                    break;
                default:
                    Console.WriteLine("Yanlış Girdiniz :)");
                    break;
            }
        }
    }
}
