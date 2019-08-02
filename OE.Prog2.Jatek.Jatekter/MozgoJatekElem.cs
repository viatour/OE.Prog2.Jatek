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
            List<JatekElem> atmeneti = new List<JatekElem>();
            JatekElem[] elemek = ter.MegadottHelyenLevok(ujx, ujy);
            foreach (JatekElem elem in elemek)
            {
                if (elem != null)
                {
                    Console.WriteLine("Nem null");
                }
                else
                {
                    Console.WriteLine("Null");
                }
            }


            if (ter.MegadottHelyenLevok(ujx, ujy) != null)
            {
                elemek = ter.MegadottHelyenLevok(ujx, ujy);
                foreach (JatekElem elem in elemek)
                {
                    elem.Utkozes(this);
                    this.Utkozes(elem);
                    if (!aktiv)
                    {
                        break;
                    }
                }
            }

            if (aktiv)
            {
                elemek = ter.MegadottHelyenLevok(ujx, ujy);
                double osszmeret = 0;
                for (int i = 0; i < elemek.Length; i++)
                {
                    osszmeret = elemek[i].Meret;
                }
                if (osszmeret + Meret <= 1)
                {
                    X = ujx;
                    Y = ujy;
                }

            }


        }
        #endregion
    }
}
