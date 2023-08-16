using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_Koleksiyonlar
{
    internal class Soru_1
    {
        private static bool asalMi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            if (i == sayi)
            {
                return true;
            }
            return false;
        }
        private static int ortalama(ArrayList arrayList)
        {
            int toplam = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                toplam = toplam + Convert.ToInt32(arrayList[i]);
            }
            return toplam / arrayList.Count;
        }
        private static void Main(string[] args)
        {

            Console.WriteLine("************** İLK SORU **************");
            //ArrayList asallar = new ArrayList();
            //ArrayList asalolmayanlar = new ArrayList();

            //Console.WriteLine("20 adet sayı giriniz: ");
            //for (int i = 0; i < 20; i++)
            //{
            //    try
            //    {
            //        int input = int.Parse(Console.ReadLine());
            //        if (input > 0)
            //        {
            //            bool sonuc = asalMi(input);
            //            if (sonuc)
            //            {
            //                asallar.Add(input);
            //            }
            //            else
            //            {
            //                asalolmayanlar.Add(input);
            //            }

            //        }
            //        else
            //        {
            //            throw new InvalidDataException("Lütfen pozitif bir sayı girin.");
            //        }

            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message.ToString());
            //    }
            //}
            //asallar.Sort();
            //asalolmayanlar.Sort();
            //Console.WriteLine("sıralı asallar dizisi: ");
            //for (int j = 0; j < asallar.Count; j++)
            //{
            //    Console.Write(asallar[j]);
            //}
            //Console.WriteLine("sıralı asal olmaynlar dizisi: ");
            //for (int k = 0; k < asalolmayanlar.Count; k++)
            //{
            //    Console.Write(asalolmayanlar[k]);
            //}
            //Console.WriteLine("asalların ortalaması: " + ortalama(asallar) + "asalların eleman sayısı: " + asallar.Count);
            //Console.WriteLine("asal olmayanların ortalaması: " + ortalama(asalolmayanlar) + "asal olmayanların eleman sayısı: " + asalolmayanlar.Count);

            Console.WriteLine("************** İKİNCİ SORU **************");



            //int[] sayiDizisi = new int[20];
            //Console.WriteLine("20 adet sayı giriniz: ");
            //for (int i = 0; i < 20; i++)
            //{
            //    sayiDizisi[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(sayiDizisi);
            //int kucukortalama = (sayiDizisi[0] + sayiDizisi[1] + sayiDizisi[2])/3;
            //int buyukortalama = (sayiDizisi[17] + sayiDizisi[18] + sayiDizisi[19]) / 3;

            //Console.WriteLine("küçük ortalama: " + kucukortalama);
            //Console.WriteLine("büyük ortalama: " + buyukortalama);
            //Console.WriteLine("ortalam toplamları: " + (buyukortalama + kucukortalama));

            Console.WriteLine("************** UCUNCU SORU **************");


            Console.WriteLine("cümle giriniz: ");
            string cumle;
            cumle = Console.ReadLine();
            List<char> sesliHarfler = new List<char>();
  
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i]==65 || cumle[i] == 69 || cumle[i] == 73|| cumle[i] == 79|| cumle[i] == 85 || cumle[i] == 97|| cumle[i] == 101|| cumle[i] == 105|| cumle[i] == 108|| cumle[i] == 111|| cumle[i] == 117)
                {
                    sesliHarfler.Add(cumle[i]);
                }

            }
            sesliHarfler.Sort();
            foreach (var harf in sesliHarfler)
            {
                Console.WriteLine(harf);
            }

        }
    }
}

