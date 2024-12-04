using Voronkin_Traffic_Control.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voronkin_Traffic_Control.Entities.Sensors
{
    public class HumiditySensor : Sensor
    {
        public override SensorType Type => SensorType.Humidity;

        public HumiditySensor(string name, string description)
            : base (name, description){}

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 100;
            Console.WriteLine($"{Name} Humidity: {Value} %");
        }
    }
}