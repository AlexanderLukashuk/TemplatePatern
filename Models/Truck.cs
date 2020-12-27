using System;

namespace TemplateCar.Models
{
    public class Truck : CarMaking
    {
        public override string Name
        {
            get
            {
                return "Грузовик";
            }
        }

        public override void GetName()
        {
            Console.WriteLine("Создаем " + this.Name);
        }

        public override void AddBox()
        {
            Console.WriteLine("Добавляем коробку для грузовика");
        }

        public override void AddWheels()
        {
            Console.WriteLine("Добавляем колеса для грузовика");
        }

        public override void AddMotor()
        {
            Console.WriteLine("Добавляем мотор для грузовика");
        }

        public override void AddBody()
        {
            Console.WriteLine("Добавляем кузов для грузовика");
        }

        public override void GetReadyCar()
        {
            Console.WriteLine("Получили готовый " + this.Name);
        }
    }
}