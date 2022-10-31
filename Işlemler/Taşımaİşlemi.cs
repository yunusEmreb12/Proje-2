using System;
namespace Console_ToDo_Uygulaması
{
    public class Taşımaİşlemi:Veri
    {
        public static void Taşı()
        {
            Console.WriteLine("Öncelikle Silmek İsteğiniz Kartı Seçmeniz Gerekiyor.");
            Console.WriteLine("Lütfen Kart Başlığını Yazınız: ");
            string input = Console.ReadLine();

            foreach (var item in kartlar)
            {
                if (item.başlık == input)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri");
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Başlık     :" + item.başlık);
                    Console.WriteLine("İçerik     :" + item.içerik);
                    Console.WriteLine("AtananKişi    :" + item.kişi);
                    Console.WriteLine("Büyüklük     :" + item.büyüklük);
                    Console.WriteLine("Line     :" + item.line);
                    Console.WriteLine();
                    Console.WriteLine("Lütfen Taşıman İstediğiniz Line'ı Seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) INPROGRESS");
                    Console.WriteLine("(3) DONE");
                    int input1 = Convert.ToInt32(Console.ReadLine());

                    switch (input1)
                    {
                        case 1:
                        item.line = "TODO";
                        break;
                        case 2:
                        item.line = "INPROGRESS";
                        break;
                        case 3:
                        item.line = "DONE";
                        break;  
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Bir Tuşlama Yaptınız.");
                    break;
                }
            }
        }
    }
}