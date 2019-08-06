using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Jatekter;
using OE.Prog2.Jatek.Szabalyok;

namespace OE.Prog2.Jatek.Szabalyok
{
    class GonoszGepiJatekos : GepiJatekos
    {
        #region Konstruktor
        public GonoszGepiJatekos(string nev, int x, int y, JatekTer ter) : base(nev, x, y, ter)
        {
        }
        #endregion

        #region Tulajdonságok
        public override char Alak
        {
            get { return '\u2642';}
        }
        #endregion

        #region Metódusok
        public void Utkozes()
        {
            var tipus = base.GetType();
            base.Utkozes(this);
            if (base.Aktiv && this is Jatekos && tipus is Jatekos)
            {
                this.Serul(10);
            }


        }
        
        #endregion
    }
}
