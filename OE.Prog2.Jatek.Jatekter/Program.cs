using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    class Program
    {
        static void Main(string[] args)
        {
            JatekTer ter = new JatekTer(500, 500);

            JatekElem elem1 = new JatekElem(2, 5, ter);
            JatekElem elem2 = new JatekElem(156, 67, ter);


            Console.ReadKey();
        }
    }
}
