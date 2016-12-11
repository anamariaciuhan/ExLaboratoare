using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Audi:Car // mvc course 4 exercitiu laborator
    {
        public int Vitezometru(int acceleratie)
        {
            if (acceleratie == 1)
            { return 50; }
            else if (acceleratie == 2)
            { return 100; }
            else if (acceleratie == 3)
            { return 150; }
            else if
        (acceleratie == 0)
            { return 0; }
            else
                return 99999999;
        }
    }
}
