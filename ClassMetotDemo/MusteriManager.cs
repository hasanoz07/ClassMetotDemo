using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //Müşteriler ile ilgili yapılabilecek işlemler ekleniyor

        //Müşteri ekleme işlemi simüle edilmiştir.
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla sisteme eklendi.");
            Console.WriteLine("Eklenen müşteri : " + musteri.Name + " " + musteri.Surname);
        }


        //Müşteri silme işlemi simüle edilmiştir.
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla silindi !");
            Console.WriteLine("Silinen müşteri : " +  musteri.Name + " " + musteri.Surname);
        }


        //Müşteri bilgileri ekrana listeleme işlemi simüle edilmiştir.
        public void MusteriBilgileriListele(Musteri musteri)
        {
            Musteri[] musteribilgi = new Musteri[] { musteri };

            foreach (Musteri musteri1 in musteribilgi)
            {
                Console.WriteLine("Müşteri Id : " + musteri1.Id);
                Console.WriteLine("Müşteri Adı : "+musteri1.Name);
                Console.WriteLine("Müşteri Soyadı : " + musteri1.Surname);
                Console.WriteLine("Müşteri Kredi Limiti : " + musteri1.CreditLimit);
                Console.WriteLine("Müşteri Bakiyesi : " + musteri1.AccountBalance);
            }
        }

    }   
    

}
