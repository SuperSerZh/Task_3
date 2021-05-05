using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you name: ");
            var name = Console.ReadLine();
            Console.Write("Enter you age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You name is {0} and age is {1}", name, age);

            Console.Write("Enter you birthdate: ");
            var birth_date = Console.ReadLine();
            Console.WriteLine("You birthdate is {0} ", birth_date);
            Console.ReadKey();
        }
    }
}
