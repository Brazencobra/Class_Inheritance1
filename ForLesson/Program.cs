using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ForLesson.Models;
using System.Diagnostics;

namespace ForLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW","E60",2,700,"Yasil",2021);
            car1.CurrentFuel = 500;
            Console.WriteLine(car1.ShowInfo());
        }
    }
}