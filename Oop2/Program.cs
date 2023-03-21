using System;

namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Omer Faruk YILMAZ
            GercekMusteri musteri1=new GercekMusteri();
            musteri1.MusteriNo = "123";
            musteri1.Adi = "Omer";
            musteri1.Soyadi = "Yılmaz";
            musteri1.TcNo = "252161621421412";
            musteri1.Id = 1;

            //Yılmazlar
            TuzelMusteri musteri2= new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1234";
            musteri2.SirketAdi = "Yılmazlar";
            musteri2.VergiNo = "21421526161";
        
            Musteri musteri3=new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager=new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);
        
        }
    }
}
