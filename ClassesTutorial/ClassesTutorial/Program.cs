﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes(); // ex 4 mvc course2, ex 9
            //AbstractCar aCar = new AbstractCar(); ex 4 mvc course2
            EngineStruct engine = new EngineStruct(); //ex 5 mvc course2
            AbstractCar car2 = new Mercedes(); // ex 6 mvc course2

            Console.WriteLine("This is my first C# project"); //ex 1 mvc course2
            Console.WriteLine("Mercede is " + mercedes.Description); //ex 9 mvc course2
            Console.WriteLine("Mercede costs  " + mercedes.Price);// ex 9 mvc course2
            Console.ReadKey();
        }
    }
}
