﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Megjelenites
{
    interface IMegjelenitheto
    {
        int[] MegjelenitendoMeret { get; }

        IKirajzolhato[] MegjelenitendoElemek();
    }
}
