using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_ToDo_Uygulaması
{
    public class Eklemeİşlemi
    {
        public static void Ekle()
        {
            Kart yeniKart = new Kart();

            Console.WriteLine("Başlık Giriniz: ");
            string input = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz XS(1), S(2), M(3), L(4), XL(5) ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Atanacak Kişiyi Giriniz: ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            yeniKart = new Kart();
            yeniKart.başlık = input;
            yeniKart.içerik = input1;

            if (input2 != null)
            {
                string büyüklükDeğeri = Enum.GetName(typeof(EnumBüyüklük), input2);
                yeniKart.büyüklük = büyüklükDeğeri;
            }
            else
            {
                Console.WriteLine("Gecersiz Bir Karakter Girdiniz. Tekrar Deneyiniz.");
                Ekle();
            }

            var Kişi = Veri.kişiler.FirstOrDefault(x => x.id == input3);
            if(Kişi != null)
            {
                Veri.kartlar.Add(yeniKart);
            }
            else
            {
                Console.WriteLine("Gecersiz Bir Karakter Girdiniz. Tekrar Deneyiniz.");
                Ekle();
            }
        }
    }
}