using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Jatekter;
using OE.Prog2.Jatek.Megjelenites;

namespace OE.Prog2.Jatek.Szabalyok
{
    class Jatekos : MozgoJatekElem, IKirajzolhato, IMegjelenitheto
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

        public char Alak
        {
            get
            {
                if (Aktiv) return '\u263A';
                else return '\u263B';
            }
        }

        public int[] MegjelenitendoMeret
        {
            get
            {
                int[] vissza = { ter.MeretX, ter.MeretY };
                return vissza;
            }
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
            int ujx = X + rx;
            int ujy = Y + ry;
            this.AtHelyez(ujx, ujy);
            //Console.WriteLine("Jelenlegi pozició: x:{0} y:{1}",X,Y);
        }

        public IKirajzolhato[] MegjelenitendoElemek()
        {
            JatekElem[] kornyekenElemek = ter.MegadottHelyenLevok(X, Y, 5);
            List<IKirajzolhato> atmeneti = new List<IKirajzolhato>();
            foreach (JatekElem elem in kornyekenElemek)
            {
                if (elem is IKirajzolhato) atmeneti.Add(elem as IKirajzolhato);
            }
            IKirajzolhato[] vissza = atmeneti.ToArray();
            return vissza;

        }


        #endregion
    }
}
