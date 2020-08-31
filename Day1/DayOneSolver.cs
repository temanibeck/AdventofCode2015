using AdventOfCode2015.Interfaces;
using AdventOfCode2015.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2015.Day1
{
    public class DayOneSolver
    {
        private FileReader _fileReader;
        private List<char> _parsedInput;
        private IElevator _elevator;

        public DayOneSolver(FileReader fileReader)
        {
            _fileReader = fileReader;
            var input = _fileReader.ReadLine("Day1/input.txt").ToArray();
            _parsedInput = input[0].ToCharArray().ToList();

            _elevator = new Elevator();
        }

        public void Execute(char instruction)
        {
            if (instruction == '(')
            {
                _elevator.MoveUp();
            }
            else 
            {
                _elevator.MoveDown();
            }
        }

        public void SolvePartOne()
        {
            _elevator.Reset();

            foreach (var instruction in _parsedInput)
            {
                Execute(instruction);
            }

            Console.WriteLine($"The solution to part one is {_elevator.GetCurrentFloor()}");
        }

        //hw: fix test for part one and part two of Day One Solver
        public void SolvePartTwo()
        {
            var count = 0;
            _elevator.Reset();

            foreach (var instruction in _parsedInput)
            {
                Execute(instruction);

                count++;

                if (_elevator.GetCurrentFloor() == -1)
                {
                    break;
                }
            }

            Console.WriteLine($"The solution to part two is {count}");
        }
    }
}
