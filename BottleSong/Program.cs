using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
          for(int  i= 99; i >= 0; i--)
            {
                Console.WriteLine($"{i} bottles of beer on wall,");
                Console.WriteLine($"{i} bottles of beer!");
                Console.WriteLine("Take one down,");
                Console.WriteLine("Pass it around");
                Console.WriteLine($"{i-1} bottles of beer on the wall");
            }
        }
    }
}
