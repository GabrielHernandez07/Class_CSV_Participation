using System;
using System.Collections.Generic;
using System.Text;

namespace Cereal
{
    public class Cereal
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }
        public Cereal()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = 0;
            Cups = 0;
        }
        public Cereal(string manufacturer, string name, double calories, double cups)
        {
            Manufacturer = manufacturer;
            Name = name;
            Calories = calories;
            Cups = cups;
        }
        public override string ToString()
        {
            return $"{Name} is made by {Manufacturer} and has {Calories.ToString()} calories for every {Cups.ToString()} cup of serving";
        }
    }
}
