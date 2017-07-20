using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
           // generate a list of 20 random numbers
           Random random = new Random();

           // Create Lists
           List <int> randomNumber = new List<int>();
           List <int> squaredNumber = new List<int>();
           List <int> squaredEvenNumber = new List<int>();

           // Populate the lists

           for (int i = 0; i < 10; i++)
           {
            randomNumber.Add(random.Next(1, 20));
           }
           
           // Populate the next list with squares of each number in current list

           Console.WriteLine("Random Numbers: ");
           foreach (int number in randomNumber)
           {
            Console.WriteLine(number);
            squaredNumber.Add(number * number);
           }

           // Then remove any odd square number

           Console.WriteLine("Squared Random Numbers: ");
           foreach (int number in squaredNumber)
           {
            Console.WriteLine(number);
            if (number % 2 == 0)
            {
                squaredEvenNumber.Add(number);
            }

           }

           Console.WriteLine("Squared Even Numbers: ");
           foreach (int number in squaredEvenNumber)
           {
               Console.WriteLine(number);
           }
           
        }
    }
}
