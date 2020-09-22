using System;

namespace AlnString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program uses for-Loop
             to count letter A/a in a given string*/

            Console.WriteLine("Enter some text");
            string userinput = Console.ReadLine();
            char searchCriteria = 'a';
            int counter = 0;

            for(int i = 0; i < userinput.Length; i++)
            {
                if (userinput.ToLower()[i] == searchCriteria)
                {
                    counter = counter + 1;
                }
            }
  
            

        
            if(counter > 0)
            {
                Console.WriteLine($"There are {counter} a's in your text");

            }
            else
            {
                Console.WriteLine($"There are no a's in your text");
            }
        
        
        
        }
    }
}
