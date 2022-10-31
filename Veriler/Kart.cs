using System;
namespace Console_ToDo_Uygulaması
{
    public class Kart
    {
        private string Başlık;
        private string İçerik;
        private string Kişi;
        private string Büyüklük;
        private string Line;

        public string başlık { get => Başlık; set => Başlık = value; }
        public string içerik { get => İçerik; set => İçerik = value; }
        public string kişi { get => Kişi; set => Kişi = value; }
        public string büyüklük { get => Büyüklük; set => Büyüklük = value; }
        public string line { get => Line; set => Line = value; }

        public Kart(string başlık, string içerik, string kişi, string büyüklük, string line)
        {
            Başlık = başlık;
            İçerik = içerik;
            Kişi = kişi;
            Büyüklük = büyüklük;
            Line = line;
        }
        public Kart(){}
    }
}