using OE.Prog2.Jatek.Jatekter;
using OE.Prog2.Jatek.Megjelenites;

namespace OE.Prog2.Jatek.Szabalyok
{
    class Fal : RogzitettJatekElem, IKirajzolhato
    {
        #region Konstruktor
        public Fal(int x, int y, JatekTer ter) : base(x, y, ter)
        {
        }
        #endregion

        #region Tulajdonságok
        public override double Meret
        {
            get { return 1; }
        }

        public char Alak
        {
            get { return '\u2593'; }
        }
        #endregion

        #region Metódusok
        public override void Utkozes(JatekElem elem)
        {
        }
        #endregion
    }
}
