﻿using System;

namespace BackWardsString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks the user's name
             and displays it vertically in reversed order
            -backwards*/

            string name = "Roland";
            Console.WriteLine(name[4]);

            for(int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
        
        
        
        
        
        
        
        }
    }
}
