using System;
using System.Linq;

namespace Console_ToDo_Uygulaması
{
    public class Silmeİşlemi : Veri
    {
        public static void Sil()
        {
            Console.WriteLine("Öncelikle Silmek İstediğiniz Kartı Seçmeniz Gerekiyor.");
            Console.WriteLine("Lütfen Kart Başlığını Yazınız: ");
            string input = Console.ReadLine();

            foreach (var item in kartlar.ToList())
            {
                if (item.başlık == input)
                {
                    kartlar.Remove(item);
                    break;
                }
                else
                {
                    Console.WriteLine("Aradağınız Kriterlere Uygun Kart Board'da Bulunamadı. Lütgen Seçim Yapınız.");
                    Console.WriteLine("* Silmeyi Sonlandırmak için (1)");
                    Console.WriteLine("* Yeniden Denemek için (2)");
                    int input1 = Convert.ToInt32(Console.ReadLine());

                    if (input1 == 1)
                    {
                        Console.WriteLine("Çıkış Yapılıyor.");
                        break;
                    }
                    else
                    {
                        Sil();
                    }
                }
            }
        }
    }
}