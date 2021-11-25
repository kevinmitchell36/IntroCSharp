using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car("Kit");
            Car anotherCar = new Car("Herbie");

            myCar.Accelerate(5);
            myCar.Accelerate(30);
            myCar.Brake(2);

            anotherCar.Accelerate(3);

            anotherCar.Brake(4);
            
        }
    }

    class Car
    {
        private int speed = 0;
        private string name;

        public Car(string carName)
        {
            name = carName;
        }

        public void Accelerate(int amount)
        {
            speed += amount;
            ShowSpeed();
        }

        public void Brake(int amount)
        {
            speed = (speed < amount) ? 0 : speed -= amount;
            ShowSpeed();
        }

        private void ShowSpeed()
        {
            Console.WriteLine($"{name} is going {speed} miles per hour.");

        }
    }
}
