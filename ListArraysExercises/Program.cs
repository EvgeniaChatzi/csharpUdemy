using System;
using System.Collections.Generic;
using System.Linq;

namespace ListArraysExercises
{
    class Program
    {
        public void Exercise1(string[] args)
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                    break;
                names.Add(input);
            }

            if (names.Count == 0)
                Console.WriteLine("0 likes");
            else if (names.Count == 1)
                Console.WriteLine($"{names[0]} likes your post");
            else if (names.Count == 2)
                Console.WriteLine($"{names[0]} and {names[1]} like your post");
            else 
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post");

        }

        public void Exercise2()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            var myArray = new char[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                myArray[i] = name[i];
            }

            foreach (var letters in myArray.Reverse())
            {
                Console.Write(letters);
            }

        }

        public void Exercise3()
        {
            Console.Write("Enter 5 numbers: ");
            var numbers = Console.ReadLine();

            var myArray = new char[numbers.Length];
            

            for (int i = 0; i < numbers.Length; i++)
            {
                myArray[i] = (char)Convert.ToInt32(numbers[i]);
            }

            Array.Sort(myArray);

            foreach (var number in myArray)
            {
                Console.WriteLine(number);
            }
        }

        public void Exercise4()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter 5 numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                     elements= input.Split(",");
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");

            }

            var numbers = new List<int>();
            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);
                numbers.Remove(min);

            }

            Console.WriteLine("the smallest numbers are: ");
            foreach (var num in smallests)
            {
                Console.WriteLine(num);
            }

        }

        static void Main()
        {
            var nums = new List<int>();
            while (true)
            {
                Console.Write("Enter a number or type 'Quit' to exit : ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                nums.Add(Convert.ToInt32(input));
            }


            var unique = new List<int>();
            foreach (var number in nums)
            {
                if(!unique.Contains(number))
                    unique.Add(number);
            }

            Console.WriteLine("the unique numbers are ");
            foreach (var number in unique)
            {
                Console.WriteLine(number);
            }

        }
    }
}
