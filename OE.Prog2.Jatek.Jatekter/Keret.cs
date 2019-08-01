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
        #endregion

        #region Metódusok
        private void PalyaGeneralas()
        {
            valosTer = new JatekTer(PALYA_MERET_X, PALYA_MERET_Y);
            //Falak generálása
            for (int i = 0; i < PALYA_MERET_X; i++)
            {
                valosTer.Felvetel(new Fal(i, 0, valosTer));
            }
            for (int i = 0; i < PALYA_MERET_X; i++)
            {
                valosTer.Felvetel(new Fal(i, PALYA_MERET_Y, valosTer));
            }
            for (int i = 0; i < PALYA_MERET_Y; i++)
            {
                valosTer.Felvetel(new Fal(0, i, valosTer));
            }
            for (int i = 0; i < PALYA_MERET_Y; i++)
            {
                valosTer.Felvetel(new Fal(PALYA_MERET_X, i, valosTer));
            }
            Random r = new Random();
            int x = 0;
            int y = 0;
            for (int i = 1; i < KINCSEK_SZAMA; i++)
            {
                x = r.Next(1, PALYA_MERET_X + 1);
                y = r.Next(1, PALYA_MERET_Y + 1);
                if ()
                {

                }
                valosTer.Felvetel(new Kincs(x, y, valosTer));
            }
        }
        #endregion
    }
}
