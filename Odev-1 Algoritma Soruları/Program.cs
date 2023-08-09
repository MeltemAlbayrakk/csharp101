//1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
//    Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
//2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
//    Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
//3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
//    Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
//4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

using System;

Console.WriteLine("********BIRINCI SORU********");

//Console.WriteLine("Pozitif bir sayı girin: ");
//int diziBoyutu = Convert.ToInt32(Console.ReadLine());
//int[] dizi= new int[diziBoyutu];    

//for (int i = 0; i < diziBoyutu; i++)
//{
//    dizi[i] = Convert.ToInt32(Console.ReadLine());
     
//}
//for (int j = 0; j < diziBoyutu; j++)
//{
//    if (dizi[j] % 2 == 0)
//        Console.Write(dizi[j]);
//}

Console.WriteLine("********IKINCI SORU********");

//Console.WriteLine("Pozitif iki sayı giriniz: ");
//int n= Convert.ToInt32(Console.ReadLine());
//int m= Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(n + " adet pozitif sayı giriniz: ");
//int[] dizi2 = new int[n]; 
//for (int i = 0; i < n; i++)
//{
//    dizi2[i] = Convert.ToInt32(Console.ReadLine());
//}

//for (int j = 0; j < n; j++)
//{
//    if (dizi2[j] == m || dizi2[j] % m == 0)
//    {
//        Console.WriteLine(dizi2[j]);
//    }
//}

//Console.WriteLine("********UCUNCU SORU********");

//Console.WriteLine("Pozitif bir sayı giriniz: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(n + "adet kelime giriniz: ");
//List<string> list = new List<string>();
//for (int i = 0; i < n; i++)
//{
//    list.Add(Convert.ToString(Console.ReadLine()));
//}
//list.Reverse();

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


//4 - Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.WriteLine("********DORDUNCU SORU********");
Console.WriteLine("cümle giriniz: ");// ali ata bin 

string cumle;

cumle=(Console.ReadLine());
int karakterSayisi = cumle.Length;
int bosluk = 0;

for (int i = 0; i < cumle.Length; i++)
{
    if (cumle[i].Equals(' '))
    {
        bosluk++;
    }
}
Console.WriteLine(karakterSayisi);
Console.WriteLine(bosluk+1);





