using System;
using System.Collections.Generic;
namespace Console_ToDo_Uygulaması
{
    public class KartDüzeni
    {
        public static void KartGöster(string line, List<Kart> listeİsmi)
        {
            Console.WriteLine(line);
            Console.WriteLine("*******************");

            foreach (var item in listeİsmi)
            {
                Console.WriteLine("Başlık     :" + item.başlık);
                Console.WriteLine("İçerik     :" + item.içerik);
                Console.WriteLine("AtananKişi     :" + item.kişi);
                Console.WriteLine("Büyüklük     :" + item.büyüklük);
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}