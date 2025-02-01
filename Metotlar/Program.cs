using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };
            */
            Urun urun1 = new Urun(); //class ın örneği -- tanımlama
            
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");

                Console.WriteLine(urun.Id +" - " +urun.Adi +" - "+ urun.Fiyati  +" - "+ urun.Aciklama);    
            }


            Console.WriteLine("---------METOTLAR-------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Krmızı elma", 45,9);
            sepetManager.Ekle2("Karpuz", "Yuvarlak Karpuz", 50,8);

        }
    }
}


//dont repeat yourself - DRY  - Clean Code (Temiz Kod) - Best Practice (İyi Uygulama)