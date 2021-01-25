using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Aytekin";
            musteri1.MusteriSoyadi = "Bilgin";
            musteri1.MusteriTc = 16235826452;
            musteri1.MusteriKredi = "Şirket Kredisi";
            musteri1.MusteriBorcu = 125000;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Sevinç";
            musteri2.MusteriSoyadi = "Bilgin";
            musteri2.MusteriTc = 17432591436;
            musteri2.MusteriKredi = "Ev Kredisi";
            musteri2.MusteriBorcu = 5000;

            Musteri musteri3= new Musteri();
            musteri3.MusteriAdi = "Muhammed";
            musteri3.MusteriSoyadi = "Bilgin";
            musteri3.MusteriTc = 5324235324;
            musteri3.MusteriKredi = "Araç Kredisi";
            musteri3.MusteriBorcu = 0;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("*************************************************");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("--------------------------------------------------");

            foreach (Musteri kisi in musteriler)
            {
                musteriManager.Listele(kisi);

            }

            musteriManager.Silmek(musteri3);

        }
    }
}
