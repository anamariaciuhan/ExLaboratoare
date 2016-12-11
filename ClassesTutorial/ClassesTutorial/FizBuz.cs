using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class FizBuz
    {
        public static string ShowFB(int x)
        {
            if (x % 3 == 0 && x % 5 == 0) { return "FizBuz"; }

            if (x % 3 == 0) { return "Fiz"; }
            if (x % 5 == 0) { return "Buz"; }
            else
            { return " " + x; }

        }
    }
}
