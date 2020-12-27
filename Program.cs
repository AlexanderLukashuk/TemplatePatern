using System;
using TemplateCar.Models;

namespace TemplateCar
{
    class Program
    {
        static void Main(string[] args)
        {
            CarMaking carMaking = new Pickup();
            carMaking.Make();
            Console.WriteLine();

            carMaking = new Bus();
            carMaking.Make();
        }
    }
}
