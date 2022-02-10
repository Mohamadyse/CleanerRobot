using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanerRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myRobot = new Robot();

            int n;
            (int X, int Y) startCoordinate;
            List<(string Direction, int NumberOfSteps)> commands;
            
            GetInput(out n, out startCoordinate, out commands);

            Console.WriteLine($" => Cleaned: {myRobot.NumberOfUniqueVerticesForAllCommands(startCoordinate, commands, n)}");
        }

        private static void GetInput(out int n, out (int X, int Y) startCoordinate, out List<(string Direction, int NumberOfSteps)> commands)
        {
            Console.WriteLine("Write the maxiumum number of commands");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Start Coordinate in format \"X Y\" .");
            var startCoordinateArr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            startCoordinate = (X: startCoordinateArr[0], Y: startCoordinateArr[1]);
            Console.WriteLine($"Write {n} commands in format \"E Number\"");
            commands = new List<(string Direction, int NumberOfSteps)>();
            for (int i = 0; i < n; i++)
            {
                string[] commandpair = Console.ReadLine().Split(" ");
                commands.Add((Direction: commandpair[0], NumberOfSteps: int.Parse(commandpair[1])));
            }
        }
    }
}
