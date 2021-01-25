using System; 
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Eklendi :" + musteri.MusteriAdi +  " " + musteri.MusteriSoyadi);
        }

        public void Listele(Musteri musteriler)
        {
            Console.WriteLine("Muşteri Adı Soyadı : " + musteriler.MusteriAdi + " " + musteriler.MusteriSoyadi);
            Console.WriteLine("Müşteri TC No : " + musteriler.MusteriTc );
            Console.WriteLine("Müşteri Kredesi : " + musteriler.MusteriKredi);
            Console.WriteLine("Müşteri Borcu : " + musteriler.MusteriBorcu  );
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public void Silmek(Musteri musteri3)
        {
            Console.WriteLine("Tebrikler Müşteri Silindi : " + musteri3.MusteriAdi + " " + musteri3.MusteriSoyadi);
        }
    }
}
