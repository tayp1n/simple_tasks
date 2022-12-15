﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        

        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] colors = new string[] { "Blue", "Black", "Red", "Green", "Yellow" };
            string[] passengerType = new string[] { "WithBody", "WithoutBody" };
            

            Transport[] arr = new Transport[10];
            
            for (int i = 0; i < arr.Length; i++)
            {
                switch (rand.Next(5))
                {
                   
                    case 0:
                        string colorPassanger = colors[rand.Next(0, colors.Length)];
                        string type = passengerType[rand.Next(0, passengerType.Length)];
                        arr[i] = new Passenger(rand.Next(18, 45), rand.Next(500), colorPassanger, rand.NextDouble() * 30 + 210, type);
                        break;
                    case 1:
                        string colorTruck= colors[rand.Next(0, colors.Length)];
                        arr[i] = new Truck(rand.Next(20, 50), rand.Next(5000), colorTruck, rand.NextDouble() * 10 + 120, rand.NextDouble() * 2 + 3);
                        break;
                    case 2:
                        string colorCargoPlane = colors[rand.Next(0, colors.Length)];
                        arr[i] = new CargoPlane(rand.Next(60, 150), rand.Next(50000), colorCargoPlane, rand.NextDouble() * 5 + 10, rand.NextDouble() * 5000 + 7000);
                        break;
                    case 3:
                        string colorPassengerPlane = colors[rand.Next(0, colors.Length)];
                        arr[i] = new PassengerPlane(rand.Next(60, 150), rand.Next(50000), colorPassengerPlane, rand.NextDouble() * 5 + 10, rand.Next(120));
                        break;
                    case 4:
                        string colorTrain = colors[rand.Next(0, colors.Length)];
                        arr[i] = new Train(rand.Next(150, 250), rand.Next(100000), colorTrain, rand.Next(10));
                        break;
                   
                }
            }
            foreach (var transport in arr)
            {
                transport.Info();
            }


        }

    }
}
