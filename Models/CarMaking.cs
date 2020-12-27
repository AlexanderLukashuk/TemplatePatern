using System;

namespace TemplateCar.Models
{
    public abstract class CarMaking
    {
        public void Make()
        {
            GetName();
            AddBox();
            AddWheels();
            AddMotor();
            AddBody();
            GetReadyCar();
        }

        public abstract string Name { get; }
        public abstract void GetName();
        public abstract void AddBox();
        public abstract void AddWheels();
        public abstract void AddMotor();
        public abstract void AddBody();
        public virtual void GetReadyCar()
        {
            Console.WriteLine("Получили машину");
        }
    }
}