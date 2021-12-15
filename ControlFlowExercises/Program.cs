using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace ControlFlowExercises
{
    class Program
    {
        public void Exercise1(string[] args)
        {
            var count = 0;
            
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }

        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or ok to exit:");
                String ans = Console.ReadLine();
                if (ans == "ok" || ans.ToLower() == "ok") break;
                sum += Convert.ToInt32(ans);
                Console.WriteLine(sum);

            }

        }

        public void Exercise3()
        {
            Console.WriteLine("enter a number: ");
            var myNum = Convert.ToInt32(Console.ReadLine());
            var fuctorial = 1;

            for (var i = 1; i <= myNum; i++)
            {
                 fuctorial *=   i;
            }
            Console.WriteLine(fuctorial);
        }

        public void Exercise4()
        {
            var random = new Random();
            var rNum = random.Next(1, 10);
            Console.WriteLine($"the random number is  {rNum}");
            Console.WriteLine("you have 4 tries to guess the number from 1 to 10!");
          

            for (var i = 1; i <= 4; i++)
            {
                Console.WriteLine("guess: ");
                var guessedN = Convert.ToInt32(Console.ReadLine());

                if (guessedN == rNum)
                {
                    Console.WriteLine("You won!");
                    return;

                }
                Console.WriteLine("You lost!");
            }
        }

        public void Exercise5()
        {
            Console.WriteLine("enter several numbers separated by comma : ");
            var myStr = Console.ReadLine();

            myStr.Replace(", ", "");

            var myArray = myStr.ToCharArray();
            int[] numArray = new int[myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                numArray[i] = Convert.ToInt32(myArray[i].ToString());
            }

            int max = numArray.Max();

            Console.WriteLine(max);

        }

        static void Main()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();
            
            var numbers = input.Split(',');
            Console.WriteLine(numbers);
            
            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);
            
            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }
            
            Console.WriteLine("Max is " + max);

         

        }





    }
}
