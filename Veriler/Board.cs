using System;
using System.Collections.Generic;
namespace Console_ToDo_Uygulaması
{
    internal class Board
    {
        public List<Kart>? ToDo { get; set;}
        public List<Kart>? InProgress { get; set;}
        public List<Kart>? Done { get; set;}
    }
}