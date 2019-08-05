using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Jatekter;

namespace OE.Prog2.Jatek.Megjelenites
{
    class KonzolosMegjelenito
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

        #region Metódusok
        public void Megjelenites()
        {
            /*
            IKirajzolhato[] kirajzolandoElemek = forras.MegjelenitendoElemek();
            int x = forras.MegjelenitendoMeret[0];
            int y = forras.MegjelenitendoMeret[1];
            int a = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    a = 0;
                    if (a < kirajzolandoElemek.Length && (forras as JatekElem).X != kirajzolandoElemek[a].X  && (forras as JatekElem).Y != kirajzolandoElemek[a].Y)
                    {
                        SzalbiztosKonzol.KiirasXY(i, j, ' ');
                        a++;
                    }
                    else
                    {
                        SzalbiztosKonzol.KiirasXY(i, j, kirajzolandoElemek[a].Alak);
                        
                    }
                }
            }
            */
            IKirajzolhato[] kirajzolandoElemek = forras.MegjelenitendoElemek();
            int x = forras.MegjelenitendoMeret[0];
            int y = forras.MegjelenitendoMeret[1];
            int a = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    a = 0;
                    if (a < kirajzolandoElemek.Length && kirajzolandoElemek[a].X == j && kirajzolandoElemek[a].Y == i)
                    {
                        SzalbiztosKonzol.KiirasXY(i, j, kirajzolandoElemek[a].Alak);
                        a++;

                    }
                    else
                    {
                        SzalbiztosKonzol.KiirasXY(i, j, ' ');
                    }
                }
            }
        }
        #endregion
    }
}
