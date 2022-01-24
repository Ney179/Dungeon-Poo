using System;
using dotnet___poo.src.Entity;

namespace dotnet___poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 2, "knight");
            Wizzard wizzard = new Wizzard("Jennica", 15, "White Wizzard");

            Console.WriteLine(wizzard.Attack(5));
            Console.WriteLine(hero.Attack());
        }
    }
}
