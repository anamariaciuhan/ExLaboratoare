using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    public class Mercedes: AbstractCar // ex 2 mvc course2, ex 4 course2, ex 6
    {
        //public string Description;
        //public int Price;
        private string _description;
        private int _price;
       // public Mercedes() // ex7 mvc course2
       //{
       //     Description = "EClass";
       //     Price=67000;
       // }

        public string Description //ex 10
        {
            get { return _description; }
            set { _description = "EClass"; }
        }
        public int Price //ex 10
        {
            get { return _price; }
            set { _price = 67000; }
        }
    }
}
