using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Keret;
using OE.Prog2.Jatek.Szabalyok;

namespace OE.Prog2.Jatek.Jatekter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Teszt
            JatekTer tesztTer = new JatekTer(500, 500);

            JatekElem elem1 = new JatekElem(2, 5, tesztTer);
            JatekElem elem2 = new JatekElem(156, 67, tesztTer);
            JatekElem elem3 = new JatekElem(5, 7, tesztTer);
            //JatekElem elem4 = new JatekElem(2, 5, tesztter);

            tesztTer.MegadottHelyenLevok(2, 5);
            //tesztter.Torles(elem1);

            JatekElem[] tomb = tesztTer.MegadottHelyenLevok(2, 5);
            int i = 1;
            foreach (var item in tomb)
            {
                Console.WriteLine("{0}.Elem || X: {1}, Y: {2}", i ,item.X, item.Y);
                i++;
            }
            */
            
            Keret.Keret teszt = new Keret.Keret();
            teszt.Futtatas();
            


            Console.ReadKey();
        }
    }
}
