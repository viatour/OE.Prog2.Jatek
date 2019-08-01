using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Jatekter;

namespace OE.Prog2.Jatek.Szabalyok
{
    class Kincs : RogzitettJatekElem
    {
        #region Konstruktor
        public Kincs(int x, int y, JatekTer ter) : base(x, y, ter)
        {
        }
        #endregion

        #region Tulajdonságok
        public override double Meret
        {
            get { return 1; }
        }
        #endregion

        #region Metódusok
        public override void Utkozes(JatekElem elem)
        {
            if (elem is Jatekos)
            {
                (elem as Jatekos).PontotSzerez(50);
                this.ter.Torles(this);
            }
        }
        #endregion
    }
}
