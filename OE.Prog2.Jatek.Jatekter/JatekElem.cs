using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    abstract class JatekElem
    {
        #region Mezők
        private int x;
        private int y;
        protected JatekTer ter;
        #endregion

        #region Konstruktor
        public JatekElem(int x, int y, JatekTer ter)
        {
            this.x = x;
            this.y = y;
            ter.Felvetel(this);
        }
        #endregion

        #region Tulajdonságok
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public abstract double Meret
        {
            get;
        }
        #endregion

        #region Metódusok
        public abstract void Utkozes(JatekElem elem);
        #endregion
    }
}
