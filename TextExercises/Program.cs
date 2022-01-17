using System;
using System.Collections.Generic;

namespace TextExercises
{
    class Program
    {
        public void Exercise1()
        {
            Console.Write("Enter numbers separated by hyphen : ");
            var input = Console.ReadLine();


            var numbers = new List<int>();
            foreach (var number in input.Split("-"))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "not Consecutive";

            Console.WriteLine(message);

        }

        static void Main()
        {

        }



        
    }
}
