using System;

namespace Console_ToDo_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                Listelemeİşlemi.Listele();
                break;
                case 2:
                Eklemeİşlemi.Ekle();
                break;
                case 3:
                Silmeİşlemi.Sil();
                break;
                case 4:
                Taşımaİşlemi.Taşı();
                break;
                default:
                Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                break;           
            }
        }
    }
}