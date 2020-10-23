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
        private int santaX = 0;
        private int santaY = 0;
        private int roboSantaX = 0;
        private int roboSantaY = 0;
        private bool santasTurn = true;

        public DayThreeSolver(FileReader fileReader)
        {
            _fileReader = fileReader;
            _input = _fileReader.ReadLine("DayThree/Input.txt").ToArray();
        }

        public void SolvePartOne()
        {
            //starting point
            coordinateSet.Add(new Coordinate(santaX, santaY));
            //for loop here
            foreach (var direction in _input[0])
            {
                Execute(direction);
                var currentCoordinate = new Coordinate(santaX, santaY); //this is new coordinate
                                                                            //check if coordinate exists in set
                if (!coordinateSet.Contains(currentCoordinate))
                {
                    coordinateSet.Add(currentCoordinate);
                }
            }

            //end loop and check count

            Console.WriteLine($"The solution to Day Three Part One is {coordinateSet.Count()}");
        }
        
        public void SolvePartTwo()
        {
            santaX = 0;
            santaY = 0;

            coordinateSet = new HashSet<Coordinate>();

            //starting point
            coordinateSet.Add(new Coordinate(santaX, santaY));

            //for loop here
            foreach (var direction in _input[0])
            {
                ExecutePartTwo(direction);
                Coordinate currentCoordinate;
                   
                if (santasTurn)
                {
                    currentCoordinate = new Coordinate(santaX, santaY); //this is new coordinate
                }
                else
                {
                    currentCoordinate = new Coordinate(roboSantaX, roboSantaY); //this is new coordinate

                }
                //check if coordinate exists in set
                if (!coordinateSet.Contains(currentCoordinate))
                {
                    coordinateSet.Add(currentCoordinate);
                }

                //toggles boolean value
                santasTurn = !santasTurn;
            }

            //end loop and check count

            Console.WriteLine($"The solution to Day Three Part Two is {coordinateSet.Count()}");


        }
        
        public void Execute(char direction)
        {
            switch (direction)
            {
                case '^':
                    //move up
                    santaY++;
                    break;
                case '<':
                    //Move left;
                    santaX--;
                    break;
                case '>':
                    //Move right;
                    santaX++;
                    break;
                case 'v':
                    //Move down;
                    santaY--;
                    break;
            }
        }

        public void ExecutePartTwo(char direction)
        {
            switch (direction)
            {
                case '^':
                    if (santasTurn)
                    {
                        //move up
                        santaY++;
                    }
                    else
                    {
                        roboSantaY++;
                    }
                    
                    break;
                case '<':
                    if (santasTurn)
                    {
                        //move left
                        santaX--;
                    }
                    else
                    {
                        roboSantaX--;
                    }
                    break;
                case '>':
                    if (santasTurn)
                    {
                        //move right
                        santaX++;
                    }
                    else
                    {
                        roboSantaX++;
                    }
                    break;
                case 'v':
                    //Move down;
                    if (santasTurn)
                    {
                        //move left
                        santaY--;
                    }
                    else
                    {
                        roboSantaY--;
                    }
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
