using OE.Prog2.Jatek.Jatekter;

namespace OE.Prog2.Jatek.Szabalyok
{
    class Fal : RogzitettJatekElem
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
        #endregion

        #region Metódusok
        public override void Utkozes(JatekElem elem)
        {
        }
        #endregion
    }
}
