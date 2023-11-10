using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLesson.Models
{
    public class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public int FuelFor1km;
        public int CurrentFuel;

        public Car(string brand, string model, int fuelfor1km, int fuelcapacity, string Color, int Year) : base(Color, Year)
        {
            Brand = brand;
            Model = model;
            FuelFor1km = fuelfor1km;
            FuelCapacity = fuelcapacity;
        }

        public string ShowInfo()
        {
            return $"{Color} {Year} {Brand} {Model} {FuelCapacity} {FuelFor1km} {CurrentFuel}";
        }

        public int Drive(int length)
        {
            if (CurrentFuel > 0 && CurrentFuel - FuelFor1km*length >= 0) 
            {
                return CurrentFuel - FuelFor1km * length;
            }
            else 
            { 
                return 0;
            }
        }
    }
}
