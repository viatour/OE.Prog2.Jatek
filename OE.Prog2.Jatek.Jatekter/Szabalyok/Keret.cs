using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Jatekter;
using OE.Prog2.Jatek.Szabalyok;
using OE.Prog2.Jatek.Megjelenites;

namespace OE.Prog2.Jatek.Keret
{
    class Keret
    {
        #region Mezők
        private const int PALYA_MERET_X = 21;
        private const int PALYA_MERET_Y = 11;
        private const int KINCSEK_SZAMA = 10;
        private JatekTer valosTer;
        private bool jatekVege = false;
        #endregion

        #region Konstruktor
        public Keret()
        {
            valosTer = new JatekTer(PALYA_MERET_X, PALYA_MERET_Y);
            PalyaGeneralas();
        }
        #endregion

        #region Metódusok
        private void PalyaGeneralas()
        {
            valosTer = new JatekTer(PALYA_MERET_X, PALYA_MERET_Y);
            //Falak generálása
            for (int i = 0; i < PALYA_MERET_X; i++)
            {
                new Fal(i, 0, valosTer);
                new Fal(i, PALYA_MERET_Y - 1, valosTer);
            }
            for (int j = 1; j < PALYA_MERET_Y-1; j++)
            {
                new Fal(0, j, valosTer);
                new Fal(PALYA_MERET_X-1, j, valosTer);
            }


            Random r = new Random();
            int x = 0;
            int y = 0;
            //TESZT KINCS
            /*new Kincs(1, 2, valosTer);
            JatekElem[] teszt = valosTer.MegadottHelyenLevok(1, 2);
            foreach (JatekElem elem in teszt)
            {
                Console.WriteLine("TESZT: X:{0} Y:{1} típusa: {2}", elem.X, elem.Y, elem);
            }*/
            //Nem fixen 10et generál
            for (int i = 0; i < KINCSEK_SZAMA; i++)
            {
                x = r.Next(1, PALYA_MERET_X-2);
                y = r.Next(1, PALYA_MERET_Y-2);
                JatekElem[] elemek = valosTer.MegadottHelyenLevok(x, y);
                double osszMeret = 0;
                foreach (JatekElem elem in elemek)
                {
                    osszMeret += elem.Meret;
                }
                if (osszMeret == 0)
                {
                    new Kincs(x, y, valosTer);
                }
            }
        }
        public void Futtatas()
        {
            KonzolosMegjelenito gui = new KonzolosMegjelenito(valosTer, 0, 0);
            Jatekos bela = new Jatekos("Béla", 1, 1, valosTer);
            KonzolosMegjelenito gui2 = new KonzolosMegjelenito(bela, 25, 0);
            //Vezérlés
            do
            {
                ConsoleKeyInfo billentyu = Console.ReadKey(true);
                switch (billentyu.Key)
                {
                    case ConsoleKey.LeftArrow:
                        bela.Megy(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        bela.Megy(1, 0);
                        break;
                    case ConsoleKey.UpArrow:
                        bela.Megy(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        bela.Megy(0, 1);
                        break;
                    case ConsoleKey.Escape:
                        jatekVege = true;
                        break;
                    default:
                        Console.WriteLine("Rossz billentyű!");
                        break;
                }
                //gui.Megjelenites();
                gui2.Megjelenites();

            } while (!jatekVege);
        }
        #endregion
    }
}
