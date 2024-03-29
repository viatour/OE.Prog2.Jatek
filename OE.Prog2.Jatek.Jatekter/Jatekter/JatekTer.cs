﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OE.Prog2.Jatek.Megjelenites;

namespace OE.Prog2.Jatek.Jatekter
{
    class JatekTer : IMegjelenitheto
    {
        #region Mezők
        private const int MAX_ELEMSZAM = 1000;
        private int elemN;
        private JatekElem[] elemek = new JatekElem[MAX_ELEMSZAM];
        private int meretX;
        private int meretY;
        #endregion

        #region Konstruktor
        public JatekTer(int meretX, int meretY)
        {
            this.meretX = meretX;
            this.meretY = meretY;
        }
        #endregion

        #region Tulajdonságok
        public int MeretX
        {
            get { return meretX; }
        }

        public int MeretY
        {
            get { return meretY; }
        }

        public int[] MegjelenitendoMeret
        {
            get
            {
                int[] meretek = { meretX, MeretY };
                return meretek;
            }
        }
        #endregion

        #region Metódusok
        public void Felvetel(JatekElem elem)
        {
            elemek[elemN] = elem;
            elemN++;
        }

        public void Torles(JatekElem elem)
        {
            int idx = 0;
            while (elemek[idx] != elem && idx < elemek.Length)
            {
                idx++;
            }
            if (idx < elemek.Length)
            {
                elemek[idx] = null;
                elemN--;
            }

        }

        public JatekElem[] MegadottHelyenLevok(int x, int y, int tav)
        {
            JatekElem[] kozeliElemek;
            List<JatekElem> atmeneti = new List<JatekElem>();
            int darab = 0;

            int x_Balra = x - tav;
            int x_Jobbra = x + tav;
            int y_Fent = y - tav;
            int y_Lent = y + tav;
            //Határok ellenőrzése
            if (x_Balra < 0) x_Balra = 0;
            if (y_Fent < 0) y_Fent = 0;
            if (x_Jobbra > meretX) x_Jobbra = meretX;
            if (y_Lent > meretY) y_Lent = meretY;

            for (int i = 0; i < elemek.Length; i++)
            {
                //Távolságon belül
                //Külön jelölni a törölt elemeket, nem nullal (elemek[i].Torolt == false)
                if ((elemek[i] != null) && (elemek[i].X >= x_Balra && elemek[i].X <= x_Jobbra && elemek[i].Y >= y_Fent && elemek[i].Y <= y_Lent))
                {
                    atmeneti.Add(elemek[i]);
                    darab++;
                }
            }
            kozeliElemek = new JatekElem[darab];
            kozeliElemek = atmeneti.ToArray();
            return kozeliElemek;

            
        }
        public JatekElem[] MegadottHelyenLevok(int x, int y)
        {
            return MegadottHelyenLevok(x, y, 0);
        }

        public IKirajzolhato[] MegjelenitendoElemek()
        {
            List<IKirajzolhato> atmeneti = new List<IKirajzolhato>();
            foreach (JatekElem elem in elemek)
            {
                if (elem is IKirajzolhato) atmeneti.Add(elem as IKirajzolhato);
            }
            IKirajzolhato[] vissza = atmeneti.ToArray();
            return vissza;
        }

        #endregion






    }
}
