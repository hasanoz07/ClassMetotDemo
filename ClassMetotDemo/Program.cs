using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bir bankanın müşteri ekleme silme bilgilerini listeleme gibi işlemleri metot bilgisi dahilinde simüle edilmiştir.
            
            
            //Tanımlanan Musteri Class'ı yarımı ile müşteri bilgileri giriliyor.
            Musteri musteri1 = new Musteri();
            musteri1.Id = 5698;
            musteri1.Name = "Ahmet";
            musteri1.Surname = "Tekin";
            musteri1.CreditLimit = 16000;
            musteri1.AccountBalance = 120000;


            Musteri musteri2 = new Musteri();
            musteri2.Id= 5699;
            musteri2.Name = "Veli";
            musteri2.Surname = "Doğan";
            musteri2.CreditLimit = 5000;
            musteri2.AccountBalance = 36500;

            Musteri musteri3 = new Musteri();
            musteri3.Id= 5700;
            musteri3.Name = "Süleyman";
            musteri3.Surname = "Çakal";
            musteri3.CreditLimit = 1000;
            musteri3.AccountBalance = 56;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 5701;
            musteri4.Name = "Salih";
            musteri4.Surname = "Demir";
            musteri4.CreditLimit = 60000;
            musteri4.AccountBalance = 560000;


            //Tanımlanan MusteriManager Class'ı ile müşteriler üzerinde yapılabilecek işlemler simüle ediliyor.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriBilgileriListele(musteri4);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriSil(musteri1);



            //Engin Demiroğ'un Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR) kursu 3.gün Ödevidir.
        }
    }
}
