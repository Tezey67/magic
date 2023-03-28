using System;

namespace magic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Математический фокус";
            Console.WriteLine("Задумай число нажми ENTER");
            Console.ReadLine();
            Console.WriteLine("Умножь число на 2 и нажми ENTER");
            Console.ReadLine();
            Console.WriteLine("Прибавь к этому 12 и нажми ENTER");
            Console.ReadLine();
            Console.WriteLine("Раздели всё на 2 и нажми ENTER");
            Console.ReadLine();
            Console.WriteLine("Введи число которое у тебя получилось");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            Console.WriteLine("Ты задумал число " + (num - 6));
            Console.WriteLine("Для завершения нажми ENTER");
            Console.ReadLine();
        }
    }
}