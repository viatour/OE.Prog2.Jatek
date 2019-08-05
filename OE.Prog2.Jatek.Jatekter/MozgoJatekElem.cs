using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    abstract class MozgoJatekElem : JatekElem
    {
        #region Mezők
        private bool aktiv = true;
        #endregion

        #region Konstruktor
        public MozgoJatekElem(int x, int y, JatekTer ter) : base(x, y, ter)
        {
        }
        #endregion

        #region Tulajdonságok
        public bool Aktiv
        {
            get { return aktiv; }
            set { aktiv = value; }
        }

        #endregion

        #region Metódusok
        public void AtHelyez(int ujx, int ujy)
        {

            
            
            JatekElem[] adottHelyenLevok = ter.MegadottHelyenLevok(ujx, ujy);
            foreach (JatekElem elem in adottHelyenLevok)
            {
                this.Utkozes(elem);
                elem.Utkozes(this);
                Console.WriteLine("{0}", elem);
                if (!this.aktiv)
                {
                    break;
                }
            }
            double osszmeret = 0;
            if (aktiv)
            {
                JatekElem[] adottHelyenLevok2 = ter.MegadottHelyenLevok(ujx, ujy);
                foreach (JatekElem elem in adottHelyenLevok2)
                {
                    osszmeret += elem.Meret;
                }
            }
            if (osszmeret + this.Meret <= 1)
            {
                this.X = ujx;
                this.Y = ujy;
            }
            
        }
        #endregion
    }
}
