using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLesson.Models
{
    public class Vehicle
    {
        public string Color;
        public int Year;


        public Vehicle(int Year)
        {
            this.Year = Year;
        }
        public Vehicle(string Color, int Year) : this(Year)
        {
            this.Color = Color;
        }
    }
}
