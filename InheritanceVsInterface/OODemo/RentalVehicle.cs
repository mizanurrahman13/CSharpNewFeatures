﻿using System;

/**
 * Inheritance is not code-sharing
 * Is-a relationship
 * Need to share common logic
 * Sharing just properties or method signature is not enough
 * Inheritance can put you in a corner
 * You need to ask the question: what is the point?
 * */

// Rental agency in Miami, FL
namespace OODemo
{
    public class RentalVehicle
    {
        public int RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
        public int NumberOfPassengers { get; set; }

        public virtual void StartEngine()
        {
            Console.WriteLine("Turn key to ignition setting");
            Console.WriteLine("Turn key to on");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Turn key to off");
        }
    }
}
