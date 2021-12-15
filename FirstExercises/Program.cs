using System;

namespace FirstExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var number = Console.ReadLine();
            var result = Int32.Parse(number);
            
            
            if (result >= 1 && result <= 10)
            {
                Console.WriteLine("your number is valid");
            }
            else
            {
                Console.WriteLine("your number is invalid!");
            }
            
            
            Console.WriteLine("Enter the first number: ");
            var firstNumber = Console.ReadLine();
            var firstResult = Int32.Parse(firstNumber);
            
            Console.WriteLine("Enter the second number: ");
            var secondNumber = Console.ReadLine();
            var secondResult = Int32.Parse(secondNumber);
            
            if (firstResult > secondResult)
            {
                Console.WriteLine("the first number is larger");
            }
            else
            {
                Console.WriteLine("the second number is larger");
            }
            
            
            Console.WriteLine("Enter the height of an image: ");
            var height = Console.ReadLine();
            var heightResultt = Int32.Parse(height);
            
            Console.WriteLine("Enter the width of an image: ");
            var width = Console.ReadLine();
            var widthResult = Int32.Parse(width);
            
            if (heightResultt > widthResult)
            {
                Console.WriteLine("the image is a portrait");
            }
            else
            {
                Console.WriteLine("the image is a landscape");
            }


            Console.WriteLine("Please enter the speed limit: ");
            var limit = Console.ReadLine();
            var limitResult = Int32.Parse(limit);

            Console.WriteLine("Please enter the car speed: ");
            var speed = Console.ReadLine();
            var speedResult = Int32.Parse(speed);

            if (speedResult <= limitResult)
            {
                Console.WriteLine("OK!");
            }
            else
            {
                var exeededLimit = speedResult - limitResult;
                var demerits = exeededLimit / 5;
                Console.WriteLine(exeededLimit);
                Console.WriteLine(demerits);


                if (demerits >= 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("demerit points : " + demerits);

                }
            }



        }
    }
}
