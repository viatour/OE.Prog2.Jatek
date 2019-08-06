using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Jatekter;
using OE.Prog2.Jatek.Automatizmus;

namespace OE.Prog2.Jatek.Megjelenites
{
    class KonzolosMegjelenito : IAutomatikusanMukodo
    {
        #region Mezők
        private IMegjelenitheto forras;
        private int pozX;
        private int pozY;

        #endregion

        #region Konstruktor
        public KonzolosMegjelenito(IMegjelenitheto forras, int pozX, int pozY)
        {
            this.forras = forras;
            this.pozX = pozX;
            this.pozY = pozY;
        }

        #endregion

        #region Tulajdonságok
        public int MukodesIntervallum
        {
            get { return 1; }
        }

        #endregion

        #region Metódusok
        public void Megjelenites()
        {
            IKirajzolhato[] kirajzolandoElemek = forras.MegjelenitendoElemek();
            int x = forras.MegjelenitendoMeret[0];
            int y = forras.MegjelenitendoMeret[1];
     
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    int a = 0;
                    while (a < kirajzolandoElemek.Length && !(kirajzolandoElemek[a].X == j && kirajzolandoElemek[a].Y == i))
                    {
                        a++;
                    }
                    if (a < kirajzolandoElemek.Length)
                    {
                        SzalbiztosKonzol.KiirasXY(j + pozX, i + pozY, kirajzolandoElemek[a].Alak);
                    }
                    else
                    {
                        SzalbiztosKonzol.KiirasXY(j + pozX, i + pozY, '-');
                    }
                    
                }
            }
        }

        public void Mukodik()
        {
            Megjelenites();
        }
        #endregion
    }
}
