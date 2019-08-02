using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Jatekter;
using OE.Prog2.Jatek.Szabalyok;

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
            }
            for (int i = 0; i < PALYA_MERET_X; i++)
            {
                new Fal(i, PALYA_MERET_Y, valosTer);
            }
            for (int i = 0; i < PALYA_MERET_Y; i++)
            {
                new Fal(0, i, valosTer);
            }
            for (int i = 0; i < PALYA_MERET_Y; i++)
            {
                new Fal(PALYA_MERET_X, i, valosTer);
            }

            Random r = new Random();
            int x = 0;
            int y = 0;
            //TESZT KINCS
            new Kincs(1, 2, valosTer);
            JatekElem[] teszt = valosTer.MegadottHelyenLevok(1, 2);
            foreach (JatekElem elem in teszt)
            {
                Console.WriteLine("TESZT: X:{0} Y:{1} típusa: {2}", elem.X, elem.Y, elem);
            }

            for (int i = 1; i < KINCSEK_SZAMA; i++)
            {
                x = r.Next(2, PALYA_MERET_X + 1);
                y = r.Next(2, PALYA_MERET_Y + 1);
                JatekElem[] elemek = valosTer.MegadottHelyenLevok(x, y);
                double osszMeret = 0;
                foreach (JatekElem elem in elemek)
                {
                    osszMeret += elem.Meret;
                }
                if (osszMeret == 0)
                {
                    valosTer.Felvetel(new Kincs(x, y, valosTer));
                }
            }
        }
        public void Futtatas()
        {
            Jatekos bela = new Jatekos("Béla", 1, 1, valosTer);
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

            } while (!jatekVege);
        }
        #endregion
    }
}
