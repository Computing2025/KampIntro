using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] fruits = ["Apple", "Banana", "Chery", "Melon"];

            //Console.WriteLine($"{fruits[0]}");
            //Console.WriteLine($"{fruits[1]}");
            //Console.WriteLine($"{fruits[2]}");
            //Console.WriteLine($"{fruits[3]}");

            List<string> fruits =  [ "Apple", "Banana", "Chery", "Melon" ];

            fruits.Add("Grape");
            Console.WriteLine(fruits[4]);

 

        }
    }
}
