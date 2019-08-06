using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Jatekter;
using OE.Prog2.Jatek.Megjelenites;

namespace OE.Prog2.Jatek.Szabalyok
{
    delegate void KincsFelvetelKezelo(Kincs felvettKincs, Jatekos felvette);
    delegate void JatekosValtozasKezelo(Jatekos jatekos, int pontszam, int eletero);
    class Kincs : RogzitettJatekElem, IKirajzolhato
    {
        public event KincsFelvetelKezelo KincsFelvetel;
        
        #region Konstruktor
        public Kincs(int x, int y, JatekTer ter) : base(x, y, ter)
        {
            //Tesztkeret
            //Console.WriteLine("Kincs helye: x: {0} y: {1}", x, y);
            //KincsFelvetel += new KincsFelvetelKezelo();
        }
        #endregion

        #region Tulajdonságok
        public override double Meret
        {
            get { return 1; }
        }

        public char Alak
        {
            get { return '\u2666'; }
        }
        #endregion

        #region Metódusok
        public override void Utkozes(JatekElem elem)
        {
            if (elem is Jatekos)
            {
                (elem as Jatekos).PontotSzerez(50);
                //Console.WriteLine("{0} pontot szerzett!",(elem as Jatekos).Nev);
                KincsFelvetel(this, elem as Jatekos);
                KincsFelvetel += Kincs_KincsFelvetel;
                this.ter.Torles(this);
            }
        }

        private void Kincs_KincsFelvetel(Kincs felvettKincs, Jatekos felvette)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
