using System;
using System.Collections.Generic;
namespace Console_ToDo_Uygulaması
{
    public class Veri
    {
        public static List<Kart> kartlar = new List<Kart>();
        public static List<Kişi> kişiler = new List<Kişi>();

        static Veri()
        {
            kişiler = new List<Kişi>()
            {
                new Kişi{id = 1, isim = "Cem"},
                new Kişi{id = 2, isim = "Oğuz"},
                new Kişi{id = 3, isim = "Melisa"},
                new Kişi{id = 4, isim = "Özlem"},
            };

            kartlar = new List<Kart>()
            {
                new Kart{başlık = "Sınav", içerik = "İktisat ödevi yapılacak", kişi = "Cem", büyüklük = "S", line = "TODO"},
                new Kart{başlık = "Proje", içerik = "TODO Projesi Tamamlanacak", kişi = "Oğuz", büyüklük = "XS", line = "DONE"},
                new Kart{başlık = "Eğitim", içerik = "C# Videoları izlenecek", kişi = "Melisa", büyüklük = "L", line = "INPROGRESS"},
                new Kart{başlık = "Ev", içerik = "Ev İşleri Tamamlanacak", kişi = "Özlem", büyüklük = "M", line = "TODO"},
            };
        }
        public static void VeriYaz()
        {
            foreach (var item in kartlar)
            {
                Console.WriteLine(item.başlık+ " " + item.içerik + " " + item.kişi + " " + item.büyüklük + " " + item.line);
            }
        }
    }
}