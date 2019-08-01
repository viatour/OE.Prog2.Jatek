using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    class JatekTer
    {
        #region Mezők
        private const int MAX_ELEMSZAM = 1000;
        private int elemN;
        private JatekElem[] elemek = new JatekElem[MAX_ELEMSZAM];
        private int meretX;
        private int meretY;
        #endregion

        #region Konstruktor
        public JatekTer(int meretX, int meretY)
        {
            this.meretX = meretX;
            this.meretY = meretY;
        }
        #endregion

        #region Tulajdonságok
        public int MeretX
        {
            get
            {
                return meretX;
            }
        }

        public int MeretY
        {
            get
            {
                return meretY;
            }
        }
        #endregion

        #region Metódusok
        public void Felvetel(JatekElem elem)
        {
            elemek[elemN] = elem;
            elemN++;
        }

        public void Torles(JatekElem elem)
        {
            int idx = 0;
            while (elemek[idx] != elem && idx < elemek.Length)
            {
                idx++;
            }
            if (idx < elemek.Length)
            {
                elemek[idx] = null;
                elemN--;
            }

        }

        public JatekElem[] MegadottHelyenLevok(int x, int y, int tav)
        {

        }
        public JatekElem[] MegadottHelyenLevok(int x, int y)
        {
            MegadottHelyenLevok(x, y, 0);
        }

        #endregion






    }
}
