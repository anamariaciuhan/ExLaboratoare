using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Orange:Fruit // mvc course 4
    {
        public Orange()
        {
            Console.WriteLine("Orange has been created");
        }

        public int GetCalories()
        {
            return 4;
        }

    }
}
