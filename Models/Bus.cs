using System;

namespace TemplateCar.Models
{
    public class Bus : CarMaking
    {
        public override string Name
        {
            get
            {
                return "Автобус";
            }
        }

        public override void GetName()
        {
            Console.WriteLine("Создаем " + this.Name);
        }

        public override void AddBox()
        {
            Console.WriteLine("Добавляем коробку для автобуса");
        }

        public override void AddWheels()
        {
            Console.WriteLine("Добавляем колеса для автобуса");
        }

        public override void AddMotor()
        {
            Console.WriteLine("Добавляем мотор для автобуса");
        }

        public override void AddBody()
        {
            Console.WriteLine("Добавляем кузов для автобуса");
        }

        public override void GetReadyCar()
        {
            Console.WriteLine("Получили готовый " + this.Name);
        }
    }
}