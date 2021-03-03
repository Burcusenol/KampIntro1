using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=999


            //int,decimal,float,double,bool=değer tip--stack de tutulur
            //array,class,interface=referans tip--heap de tutulur
            //new:bellekte yeni bir yer tutmaya yarar
            // REFERANS TİPLERDE ADRESE ATAMA YAPIYORSUN!!
            //C dilinde pointer
            //Metotlarda default değerler en sonda bulunur.
            //ref keywordu:Değer tipi referans tip gibi kullanmayı sağlar
            //out:ref den farkı değer istememesidir
            //params:dizi formatında parametre vereceğimiz zaman kullanırız

        }
    }
}
