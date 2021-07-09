using System;
using System.Collections.Generic;
using System.Linq;

namespace HepsiBurada_Case_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Direction> directions = new Dictionary<string, Direction>()
            {
                { "W", new West() },
                { "E", new East() },
                { "S", new South() },
                { "N", new North() }
            };

            Dictionary<string, Turn> turns = new Dictionary<string, Turn>()
            {
                { "L", Turn.LEFT },
                { "R", Turn.RIGHT },
            };

            string upperRightCoordinat;
            Console.WriteLine("Upper-right coordinates of the plateau");
            upperRightCoordinat = Console.ReadLine();
            int plateauUpperRightX = Convert.ToInt32(upperRightCoordinat[0]);
            int plateauUpperRightY = Convert.ToInt32(upperRightCoordinat[1]);
            string input;
            int roverCount = 1;
            Rover rover;
            while (true)
            {
                Console.WriteLine(roverCount + ".Rover's Position");
                input = Console.ReadLine();

                string[] roverPositionDetails = input.Split(" ");

                int posX = Convert.ToInt32(roverPositionDetails[0]);
                int posY = Convert.ToInt32(roverPositionDetails[1]);
                string direction = roverPositionDetails[2];

                Compass compass = new Compass(directions[direction]);
                rover = new Rover(posX, posY, plateauUpperRightX, plateauUpperRightY, compass);

                Console.WriteLine(roverCount + ".Rover's series of instructions");
                input = Console.ReadLine();
                string[] roverIstructions = input.Select(x => x.ToString())
                                 .ToArray();
                bool hasError = false;
                foreach (var instruction in roverIstructions)
                {
                    if (turns.ContainsKey(instruction))
                        rover.Spin(turns[instruction]);
                    else if (instruction == "M")
                        if (!rover.Move())
                        {
                            Console.WriteLine("Commands are blocked. Can you try again");
                            hasError = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Commands are blocked. Can you try again");
                            hasError = true;
                            break;
                        }
                }
                if (hasError)
                    continue;
                Console.WriteLine(rover.ToString());
                roverCount++;
            }
        }
    }
}
