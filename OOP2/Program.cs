using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ali Bak
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Bak";
            musteri1.TcNo = "1234567889";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123587456";

            //Gerçek Müşteri - Tüzel Müşteri--Birbirini yerine kullanılmaz.

            //SOLID


            //new:referans no
            //Hem gerçek hem tüzelin rferasnını tutuyor
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);

        }
    }
}
