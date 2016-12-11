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

        private int counter;
        public static int staticcounter;

        /* public Mercedes() // ex7 mvc course2
         {
           Description = "EClass";
            Price=67000;
        }*/

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
        public static void StartEngine() // exercitiul 1 mvc course 3
        {
            Console.WriteLine("Engine started");
        }

        public void ShowRemainingNoOFKM1(int noofFuelLiters, int Consump) //exercitiul 2 mvc course 3
        {
           Console.WriteLine("Remaining km ex2.course3: " +noofFuelLiters / Consump * 100 ); 
        }
        public double ShowRemainingNoOfKM(double noOfFuelLiters, double Consumption) // exercitiul 3 mvc course 3
        {

            double result = 0; 
            result = noOfFuelLiters / Consumption * 100;

            return result;

        }

        public string StartEngine(int NrMilisecunde) // exercitiul 4 mvc course 3
        {
            string mesaj = "The car is starting in " + NrMilisecunde + " milliseconds";

            return mesaj ;
        }

        public double CalculateConsumption(params int[] kms) // exercitiul 5 mvc course 3
        {
            double sum = 0;
            foreach (int km in kms)
                sum += km;
            return sum / 100 * 7;
        }
        public void PrintMercedesLogo()
        {
            Console.WriteLine("This is from mercedes");
            PrintMercedesLogo();
            counter++;
            if (counter == 3)
            {
                return;
            }
        }


        public void PrintNewMercedes(int counter)
        {
            if (counter == 3) { return; }
            Console.WriteLine("Mercedes no.= " + counter);
        }




    }
}
