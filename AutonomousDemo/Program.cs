﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    class Program
    {
        static void Main(string[] arg)
        {
            VehicleMotion vehicleMotion = new VehicleMotion(0);
            Speedometer speedometer = new Speedometer();
            speedometer.SpeedometerDisplay(vehicleMotion, 8, 202);
         
        }
    }
}
