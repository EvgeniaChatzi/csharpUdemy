using System;
using CSharpUdemyCourse.Math;

namespace CSharpUdemyCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var zenya = new Person();
            zenya.firstName = "Zenya";
            zenya.lastName = "Chatzi";
            zenya.Introduce();
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var names = new string[] {"one", "two", "three"};
        }
    }
}
