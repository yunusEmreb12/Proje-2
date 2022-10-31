using System;
using System.Linq;

namespace Console_ToDo_Uygulaması
{
    public class Listelemeİşlemi
    {
        private static Board boards;
        public static void LineBoard()
        {
            var todo = Veri.kartlar.Where(x => x.line == "TODO").ToList();
            var inprogress = Veri.kartlar.Where(x => x.line == "INPROGRESS").ToList();
            var done = Veri.kartlar.Where(x => x.line == "DONE").ToList();

            boards = new Board();
            boards.ToDo = todo;
            boards.InProgress = inprogress;
            boards.Done = done;
        }

        public static void Listele()
        {
            LineBoard();
            KartDüzeni.KartGöster("TODO Line", boards.ToDo);
            KartDüzeni.KartGöster("INPROGRESS Line", boards.InProgress);
            KartDüzeni.KartGöster("DONE Line", boards.Done);
        }
    }
}