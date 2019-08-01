using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    class JatekElem
    {
        #region Mezők
        private int x;
        private int y;
        private JatekTer ter;
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
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        #endregion

    }
}
