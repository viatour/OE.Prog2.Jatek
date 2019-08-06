using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Jatekter;
using OE.Prog2.Jatek.Szabalyok;
using OE.Prog2.Jatek.Automatizmus;

namespace OE.Prog2.Jatek.Szabalyok
{
    class GepiJatekos : Jatekos, IAutomatikusanMukodo
    {
        #region Mezők
        static Random r = new Random();
        #endregion

        #region Konstruktor
        public GepiJatekos(string nev, int x, int y, JatekTer ter) : base(nev, x, y, ter)
        {
        }
        #endregion

        #region Tulajdonságok
        public override char Alak
        {
            get { return '\u2640'; }
        }

        public int MukodesIntervallum
        {
            get { return 2; }
        }
        #endregion

        #region Metódusok
        public void Mozgas()
        {
            int random = 0;
            random = r.Next(0, 4);
            switch (random)
            {
                case 0: Megy(0, -1);
                    break;
                case 1: Megy(1, 0);
                    break;
                case 2: Megy(0, 1);
                    break;
                case 3: Megy(-1, 0);
                    break;
                default: Console.WriteLine("Hiba");
                    break;
            }
        }

        public void Mukodik()
        {
            Mozgas();
        }
        #endregion

    }
}
