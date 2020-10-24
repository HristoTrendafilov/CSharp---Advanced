using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire(double tire1Pressure, int tire1age, double tire2Pressure, int tire2age, double tire3Pressure, int tire3age, double tire4Pressure, int tire4age)
        {
            Tire1Pressure = tire1Pressure;
            Tire1Age = tire1age;
            Tire2Pressure = tire2Pressure;
            Tire2Age = tire2age;
            Tire3Pressure = tire3Pressure;
            Tire3Age = tire3age;
            Tire4Pressure = tire4Pressure;
            Tire4Age = tire4age;
        }
        public double Tire1Pressure { get; set; }
        public int Tire1Age { get; set; }
        public double Tire2Pressure { get; set; }
        public int Tire2Age { get; set; }
        public double Tire3Pressure { get; set; }
        public int Tire3Age { get; set; }
        public double Tire4Pressure { get; set; }
        public int Tire4Age { get; set; }
    }
}
