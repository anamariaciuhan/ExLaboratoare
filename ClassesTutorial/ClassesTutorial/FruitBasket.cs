using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    public class FruitBasket
    {
        List<Fruit> listaFructe;

        public FruitBasket()
        {
            listaFructe = new List<Fruit>();

        }
        public void addFruit(Fruit fruct)
        {

            listaFructe.Add(fruct);
        }
        public void displayFruitsCalories()
        {

            foreach (Fruit f in listaFructe)
            {
                Console.WriteLine(f.GetCalories());
            }
        }

    }
}