using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Eklenen müsterinin");
            Console.WriteLine("ID no:" + musteri.Id);
            Console.WriteLine("Adı:"+musteri.Ad);
            Console.WriteLine("Soyadı:"+musteri.Soyad);
            Console.WriteLine("-----------------");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+"No'lu ID ye sahip kişi silindi.");
            Console.WriteLine("Adı:" + musteri.Ad);
            Console.WriteLine("Soyadı:" + musteri.Soyad);
            Console.WriteLine("-----------------------------------");
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+ "No'lu ID ye sahip kişi Güncellendi.");
            Console.WriteLine("Adı:" + musteri.Ad);
            Console.WriteLine("Soyadı:" + musteri.Soyad);
            Console.WriteLine("-----------------------------------");
        }
    }
}
