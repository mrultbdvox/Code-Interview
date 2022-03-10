using FindHobby.Core;
using System;

namespace FindHobby.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello FindHobbies!");
            if (args.Length != 2)
                throw new ArgumentException("This command line tool requires two arguments: [level] [position]");
            var (levelStr, posStr) = (args[0], args[1]);

            if(!int.TryParse(levelStr, out var level) || !int.TryParse(posStr, out var pos))
                throw new ArgumentException("Both arguments need to be whole numbers: [level] [position]");

            System.Console.WriteLine($"The level {level} and position {pos} results in: {Solution.Find(level, pos)}");
        }
    }
}
