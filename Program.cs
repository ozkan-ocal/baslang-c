using System;

namespace kosullar

{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety=tip güvenliği
            //Do not repeat your self=kendini tekrarlama
            string kategoriEtiketi = "kategoriler";
            int ogrenciSayısı = 32000;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            bool sistemeGirisYapmisMi = true; //genelde veri kaynağından gelir
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar azalış göstergesi");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("dolar artış göstergesi");
            }
            else
            {
                Console.WriteLine("dolar sabit göstergesi");
            }
            if (sistemeGirisYapmisMi == true)
            {

                Console.WriteLine("ayarlar butonu");

            }
            else
            {
                Console.WriteLine("tekrar dene");
            }
            Console.WriteLine(kategoriEtiketi);




        }
    }
}
