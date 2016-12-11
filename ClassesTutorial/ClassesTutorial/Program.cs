using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
        static int counter;
        static void PrintLogo() // course 3
        {
            Console.WriteLine("I am learning C#");
            Console.WriteLine("C# is great");

            PrintLogo2();

        }
        static void PrintLogo(int i) //course 3
        {
            Console.WriteLine("Another print logo");
        }
        static void PrintLogo2() //course 3
        {

            counter++;
            if (counter == 3)
            {

                return;
            }
            Console.WriteLine("Print Logo 2");

        }
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes(); // ex 4 mvc course2, ex 9
            //AbstractCar aCar = new AbstractCar(); ex 4 mvc course2
            EngineStruct engine = new EngineStruct(); //ex 5 mvc course2
            AbstractCar car2 = new Mercedes(); // ex 6 mvc course2
            ICar car = new Mercedes();

            Console.WriteLine("This is my first C# project"); //ex 1 mvc course2
            Console.WriteLine("Mercedes is " + mercedes.Description ); //ex 9 mvc course2
            Console.WriteLine("Mercedes costs  " + mercedes.Price);// ex 9 mvc course2
            PrintLogo(); //mvc course 3
            PrintLogo(1); //mvc course 3
            Console.WriteLine(FizBuz.ShowFB(3)); //exercitiu laborator

            Mercedes.StartEngine(); // ex 1 course 3

            Mercedes mercedesm1 = new Mercedes();
            mercedesm1.PrintNewMercedes(Mercedes.staticcounter++);
            Mercedes mercedesm2 = new Mercedes();
            Mercedes mercedesm3 = new Mercedes();
            Mercedes mercedesm4 = new Mercedes();
            mercedesm2.PrintNewMercedes(Mercedes.staticcounter++);
            mercedesm3.PrintNewMercedes(Mercedes.staticcounter++);
            mercedesm4.PrintNewMercedes(Mercedes.staticcounter++);
           

            Mercedes mercedesnou = new Mercedes();
            mercedesnou.ShowRemainingNoOFKM1(100, 20); //ex 2 mvc course 3

            double noOfKmLeft = mercedesnou.ShowRemainingNoOfKM(10, 7); // ex 3 mvc course 3
            Console.WriteLine("Remaining km ex3.course 3 = " + noOfKmLeft);
          
            Console.WriteLine(mercedesnou.StartEngine(100)); // exercitiul 4 mvc course 3
            Console.WriteLine(mercedesnou.CalculateConsumption(600,200)); //exercitiul 5 mvc course 3

            Audi audi1 = new Audi();
            audi1.CarStart();
            Console.WriteLine(audi1.Vitezometru(50));

            Apple a = new Apple();
            Orange o = new Orange();
            Fruit a2 = new Apple();
            Fruit o2 = new Orange();
            Ionatan i = new Ionatan();

            i.GetCalories();

            FruitBasket fb = new FruitBasket();
            fb.addFruit(a2);
            fb.addFruit(o2);

            fb.displayFruitsCalories();

            Console.ReadKey();
            
        }
    }
}
