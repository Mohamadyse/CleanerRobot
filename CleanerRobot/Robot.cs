using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanerRobot
{
    public class Robot
    {

        public IEnumerable<(int X_Coordinate, int Y_Coordinate)> GetAllNewPlacesPerCommand((int X, int Y) startCoordinate, (string Direction, int NumberOfSteps) comand)
        {
            var rangeOfSteps = Enumerable.Range(1, comand.NumberOfSteps);
            switch (comand.Direction)
            {
                case "N":
                    return rangeOfSteps.Select(step => (startCoordinate.X, startCoordinate.Y - step));

                case "S":
                    return rangeOfSteps.Select(step => (startCoordinate.X, startCoordinate.Y - step));

                case "E":
                    return rangeOfSteps.Select(step => (startCoordinate.X + step, startCoordinate.Y));

                case "W":
                    return rangeOfSteps.Select(step => (startCoordinate.X - step, startCoordinate.Y));

                default: return Enumerable.Empty<(int X, int Y)>();
            }
        }

        public int NumberUniquePlacesForAllCommands((int X, int Y) startCoordinate, List<(string Direction, int NumberOfSteps)> commands, int n)
        {
            List<(int, int)> allPlaces = new List<(int, int)>() { startCoordinate };

            var currentCoordinate = startCoordinate;
            foreach (var command in commands)
            {
                var allNewPlacesPerCommand = GetAllNewPlacesPerCommand(currentCoordinate, command);
                currentCoordinate = allNewPlacesPerCommand.LastOrDefault();
                allPlaces.AddRange(allNewPlacesPerCommand);
            }

            return allPlaces.Distinct().Count();
        }
    }
}
