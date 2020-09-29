using AdventOfCode2015.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2015.DayThree
{
    public class DayThreeSolver
    {
        private FileReader _fileReader;
        private string[] _input;
        private HashSet<Coordinate> coordinateSet = new HashSet<Coordinate>();
        private int currentX = 0;
        private int currentY = 0;

        public DayThreeSolver(FileReader fileReader)
        {
            _fileReader = fileReader;
            _input = _fileReader.ReadLine("DayThree/Input.txt").ToArray();
        }

        public void SolvePartOne()
        {
            //starting point
            coordinateSet.Add(new Coordinate(currentX, currentY));
            //for loop here
            foreach (var direction in _input[0])
            {
                Execute(direction);
                var currentCoordinate = new Coordinate(currentX, currentY); //this is new coordinate
                                                                            //check if coordinate exists in set
                if (!coordinateSet.Contains(currentCoordinate))
                {
                    coordinateSet.Add(currentCoordinate);
                }
            }

            //end loop and check count

            Console.WriteLine($"The solution to Part One is {coordinateSet.Count()}");
        }

        public void SolvePartTwo()
        {
            //track Santa moves

            //track Robo-Santa moves


        }

        public void Execute(char direction)
        {
            switch (direction)
            {
                case '^':
                    //move up
                    currentY++;
                    break;
                case '<':
                    //Move left;
                    currentX--;
                    break;
                case '>':
                    //Move right;
                    currentX++;
                    break;
                case 'v':
                    //Move down;
                    currentY--;
                    break;
            }
        }
    }

    struct Coordinate
    {
        public int X;
        public int Y;

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
