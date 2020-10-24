using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Car
    {
        public Car(string model, string weight, string color, Engine engine)
        {
            Model = model;
            Weight = weight;
            Color = color;
            Engine = engine;
        }

        public string Model { get; set; }  
        public string Weight { get; set; }  
        public string Color { get; set; } 
        public Engine Engine { get; set; } 
    }
}
