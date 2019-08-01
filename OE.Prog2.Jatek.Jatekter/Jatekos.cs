using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Jatekter;

namespace OE.Prog2.Jatek.Szabalyok
{
    class Jatekos : MozgoJatekElem
    {
        #region Mezők
        private string nev;
        private int eletero;
        private int pontszam;
        #endregion

        #region Konstruktor
        public Jatekos(string nev, int x, int y, JatekTer ter) : base(x, y, ter)
        {
            this.nev = nev;
            eletero = 100;
            pontszam = 0;
        }
        #endregion

        #region Tulajdonságok
        public string Nev
        {
            get { return nev; }
        }

        public override double Meret
        {
            get { return 0.2; }
        }
        #endregion

        #region Metódusok
        public override void Utkozes(JatekElem elem)
        {
        }

        public void Serul(int serules)
        {
            if (eletero > 0)
            {
                if ((eletero - serules) >= 0)
                {
                    eletero -= serules;
                }
            }
            if (eletero == 0) Aktiv = false; 
        }
        public void PontotSzerez(int pontszam)
        {
            this.pontszam += pontszam;
        }

        public void Megy(int rx, int ry)
        {
            this.AtHelyez(this.X += rx, this.Y += ry);
        }

        
        #endregion
    }
}
