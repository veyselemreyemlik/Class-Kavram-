using System;

namespace Class_Kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan();
            calisan.ad = "Ahmet";
            calisan.soyAd = "Demir";
            calisan.No = 211;
            calisan.Departman = "İnsan Kaynakları";

            calisan.CalisanBilgiler();

            Calisan calisan1 = new Calisan();
            calisan1.ad = "Mehmet";
            calisan1.soyAd = "Demir";
            calisan1.No = 444;
            calisan1.Departman = "Sekreterlik";

            calisan1.CalisanBilgiler();

        }
    }

    class Calisan
    {
        public string ad;
        public string soyAd;
        public int No;
        public string Departman;

        public void CalisanBilgiler()
        {
            Console.WriteLine("Çalışan Adı:" +" "+ ad);
            Console.WriteLine("Çalışan SoyAdı:" + " " + soyAd);
            Console.WriteLine("Çalışan Numarası:" + " " + No);
            Console.WriteLine("Çalışan Departmanı:" + " " + Departman);
        }


    }
}
