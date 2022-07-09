using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Tolga";
            musteri1.Soyad = "Çevik";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Levent";
            musteri2.Soyad = "Kırca";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Ata";
            musteri3.Soyad = "Demirer";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Cem";
            musteri4.Soyad = "Yılmaz";



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);

            musteriManager.MusteriSil(musteri2);

            musteriManager.MusteriGuncelle(musteri3);

        }
    }
}
