using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0001;
            musteri1.Ad = "Muhittin";
            musteri1.Soyad = "Topalak";
            musteri1.dogumyili = 1983;
            musteri1.Sehir = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 0002;
            musteri2.Ad = "Zafer";
            musteri2.Soyad = "Algöz";
            musteri2.dogumyili = 1961;
            musteri2.Sehir = "Kars";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 0003;
            musteri3.Ad = "Berke Can";
            musteri3.Soyad = "Bal";
            musteri3.dogumyili = 2001;
            musteri3.Sehir = "İstanbul";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 0004;
            musteri4.Ad = "Gazanfer";
            musteri4.Soyad = "Nevizade";
            musteri4.dogumyili = 1951;
            musteri4.Sehir = "İstanbul";

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Sil(musteri2);
            musterimanager.Bilgi(musteri4);

        }
    }
}
