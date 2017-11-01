using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class ElectricEngine
    {
        public ElectricEngine(float BatteryCapacity)
        {
            Console.WriteLine($"Engine Capacity {BatteryCapacity} kWh\n");
        }
    }
    class GasolineEngine
    {
        public GasolineEngine(float liters)
        {
            Console.WriteLine($"Engine Capacity {liters} Liters\n");
        }
    }
    class GasEngine
    {
        public GasEngine(float cubeliters)
        {
            Console.WriteLine($"Engine Capacity {cubeliters} Cubeliters\n");
        }
    }

    public class Cars
    {
        public string Brand;
        public string Model;
        public string Year;
        public string Color;
        public string Weight;
    }
    public class Car1 : Cars
    {
        public Car1()
        {
            Brand = "Kia";
            Model = "Rio";
            Year = "2017";
            Color = "White";
            Weight = "1500kg";
            Console.WriteLine($"Brand:{Brand}\nModel:{Model}\nYear:{Year}" +
                $"\nColor:{Color}\nWeight{Weight}");
            new GasolineEngine(34);
        }
    }
    public class Car2 : Cars
    {
        public Car2()
        {
            Brand = "Toyota";
            Model = "Dune";
            Year = "2005";
            Color = "Red";
            Weight = "1200kg";
            Console.WriteLine($"Brand:{Brand}\nModel:{Model}\nYear:{Year}" +
                $"\nColor:{Color}\nWeight{Weight}");
            new GasEngine(20);
        }
    }
    public class Car3 : Cars
    {
        public Car3()
        {
            Brand = "Tesla";
            Model = "Model S";
            Year = "2015";
            Color = "Black";
            Weight = "1850kg";
            Console.WriteLine($"Brand:{Brand}\nModel:{Model}\nYear:{Year}" +
                $"\nColor:{Color}\nWeight{Weight}");
            new ElectricEngine(75);
        }
    }
}
