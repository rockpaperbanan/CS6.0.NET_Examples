﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");

            // Use the Action<> delegate to point to DisplayMessage
            Action<string, ConsoleColor, int> actionTarget = 
                new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);

            Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);
            string sum = funcTarget2(90, 300);
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        // This is a target for the Action<> delegate
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Set color of console text
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for(int i=0; i<printCount; ++i )
            {
                Console.WriteLine(msg);
            }

            // restore color
            Console.ForegroundColor = prev;
        }

        // Target for the Func<> delegate
        static int Add(int x, int y)
        {
            return x + y;
        }

        // 2nd Target for the Func<> delegate
        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
