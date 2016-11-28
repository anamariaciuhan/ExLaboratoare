using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    public class Mercedes: AbstractCar // ex 2 mvc course2, ex 4 course2, ex 6
    {
        public string Description;
        public int Price;
        public Mercedes() // ex7 mvc course2
       {
            Description = "EClass";
            Price=67000;
        }
    }
}
