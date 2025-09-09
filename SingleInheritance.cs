using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    class Vehicle
    {
        // Common-attributes of all vehicle using constructor
        public int Id;
        public int WheelCount;
        public string Color;
        public int SittingCapacity;
        public Vehicle(int id, int wheelCount, string color, int sittingCapacity)
        {
            Id = id;
            WheelCount = wheelCount;
            Color = color;
            SittingCapacity = sittingCapacity;
        }
        public void ShowVehicleDetails()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Wheel Count: " + WheelCount);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Sitting Capacity: " + SittingCapacity);
        }
    }
    class Car : Vehicle
    {
        // Some attributes of car only
        public string ModelName;

        // Constructor of Car calls base class constructor
        public Car(int id, int wheelCount, string color, int sittingCapacity, string modelName)
            : base(id, wheelCount, color, sittingCapacity)
        {
            ModelName = modelName;
        }
        public void ShowCarInfo()
        {
            ShowVehicleDetails();  // method from Vehicle
            Console.WriteLine("Model : " + ModelName);
        }
    }

    internal class SingleInheritance
    {
        public static void Main(String[] args)
        {
            Car obj = new Car(1, 4, "Black", 5, "Swift");
            obj.ShowCarInfo();
        }
    }
}
