using System;
namespace first_Git___app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Git-сервис!");
            Console.WriteLine($"Дата: {DateTime.Now:dd.MM.yyyy}");
            Console.WriteLine($"3 + 5 = {Calculator.Add(3, 5)}");
        }
    }
}
