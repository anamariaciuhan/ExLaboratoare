using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Apple:Fruit // mvc course 4
    {
        string color;
        public Apple()
        {
            Console.WriteLine("Apple has been created");
        }

        public override int GetCalories()
        {
            return 2;
        }
    }
}

