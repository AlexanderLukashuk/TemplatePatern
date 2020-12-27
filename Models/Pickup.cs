using System;

namespace TemplateCar.Models
{
    public class Pickup : CarMaking
    {
        public override string Name
        {
            get
            {
                return "Пикап";
            }
        }

        public override void GetName()
        {
            Console.WriteLine("Создаем " + this.Name);
        }

        public override void AddBox()
        {
            Console.WriteLine("Добавляем коробку для пикапа");
        }

        public override void AddWheels()
        {
            Console.WriteLine("Добавляем колеса для пикапа");
        }

        public override void AddMotor()
        {
            Console.WriteLine("Добавляем мотор для пикапа");
        }

        public override void AddBody()
        {
            Console.WriteLine("Добавляем кузов для пикапа");
        }

        public override void GetReadyCar()
        {
            Console.WriteLine("Получили готовый " + this.Name);
        }
    }
}