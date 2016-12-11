using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    public class Fruit // mvc course 4
    {
        int fibres;

        public Fruit()
        {
            Console.WriteLine("fruit has been created");
        }
        public virtual int GetCalories()
        {
            return 1;
        }
    }
}
