﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with Timer type *****\n");

            // Create the delegate for the Timer type
            TimerCallback timeCB = new TimerCallback(PrintTime);

            // Establish timer settings
            Timer t = new Timer(
                timeCB,     // The TimerCallback delegate obj
                "Hello from Main",       // Any info to pass into the called method (null for no info)
                0,          // Amount of time to wait before starting (milliseconds)
                1000);      // Interval of time between calls (milliseconds)

            Console.WriteLine("Hit key to terminate...");
            Console.ReadLine();
        }

        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}, Param is: {1}",
                DateTime.Now.ToLongTimeString(), state.ToString());
        }
    }

    
}
