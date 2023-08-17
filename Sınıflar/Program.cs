﻿// Söz dizimi
// class sinifAdi
//{
//[Erişim belirleyici] [Veri tipi] OzellikAdi;
//[Erişim belirleyici] [Geri dönüş tipi] MetotAdi([Parametre Listesi])
//{
//Metot komutları
//}
//}

//Erişim belirleyiciler
// * Public
// * Private
// * Internal
// * Protected
    Console.WriteLine("*****Çalışan 1******");
    Calisan calisan1 = new Calisan("Meltem", "albayrak", 1806538, "IT");
    calisan1.CalisanBilgileri();

    Console.WriteLine("*****Çalışan 2******");
    Calisan calisan2 = new Calisan();
    calisan1.Ad = "merve";
    calisan1.Soyad = "albayrak";
    calisan1.No = 123456;
    calisan1.Departman = "Finans";
    calisan1.CalisanBilgileri();

    Console.WriteLine("*****Çalışan 3******");
    Calisan calisan3 = new Calisan("Meltem", "albayrak");
    calisan3.CalisanBilgileri();
		

		class Calisan
        {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman) // Constructor 
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan() { } //Constructor 2

        public Calisan(string ad, string soyad) { } // Constructor 3
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
}