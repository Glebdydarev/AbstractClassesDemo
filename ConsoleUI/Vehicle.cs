﻿using System;
namespace ConsoleUI
{


    public abstract class Vehicle

    {
        public int Year { get; set; }
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";


        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtual in drive ");


        }

    }
}
