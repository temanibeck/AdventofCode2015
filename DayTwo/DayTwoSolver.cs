using AdventOfCode2015.Utilities;
using System;
using System.Linq;

namespace AdventOfCode2015.DayTwo
{
    public class DayTwoSolver
    {
        private FileReader _fileReader;
        private string[] _input;
        private int runningRibbonTotal = 0;
        private int runningTotalCount = 0;

        public DayTwoSolver(FileReader fileReader)
        {
            _fileReader = fileReader;
            _input = _fileReader.ReadLine("DayTwo/input.txt").ToArray();
        }

        public void SolvePartOne()
        {
            foreach (string instruction in _input)
            {
                var dimensions = ParseInstruction(instruction);
                AddSquareFeet(dimensions[0], dimensions[1], dimensions[2]);
            }

            Console.WriteLine($"The solution to Day Two Part One is {runningTotalCount}");
        }

        public void SolvePartTwo()
        {
            foreach (string instruction in _input)
            {
                var dimensions = ParseInstruction(instruction);
                AddRibbon(dimensions[0], dimensions[1], dimensions[2]);
            }

            Console.WriteLine($"The solution to Day Two Part Two is {runningRibbonTotal}");
        }

        private int[] ParseInstruction(string instruction)
        {
            var parsedInstruction = instruction.Split('x');

            int[] instructionsAsIntegers = new int[3];

            for (int i = 0; i < parsedInstruction.Length; i++)
            {
                instructionsAsIntegers[i] = Int32.Parse(parsedInstruction[i]);
            }

            return instructionsAsIntegers;
        }

        private int CalculateArea(int dimensionOne, int dimensionTwo)
        {
            return 2 * (dimensionOne * dimensionTwo);
        }

        private int CalculatePerimeter(int dimensionOne, int dimensionTwo)
        {
            return (dimensionOne *2) + (dimensionTwo * 2);
        }

        private int GetMin(int sideOne, int sideTwo, int sideThree)
        {
            return Math.Min(Math.Min(sideOne, sideTwo), sideThree);
        }

        private void AddSquareFeet(int length, int width, int height)
        {
            int perimeterOfSideOne = CalculateArea(length, width);
            int perimeterOfSideTwo = CalculateArea(width, height);
            int perimeterOfSideThree = CalculateArea(height, length);
            int surfaceArea = perimeterOfSideOne + perimeterOfSideTwo + perimeterOfSideThree;

            if (GetMin(perimeterOfSideOne, perimeterOfSideTwo, perimeterOfSideThree) == perimeterOfSideOne)
            {
                //p1 is smallest
                runningTotalCount += surfaceArea + perimeterOfSideOne / 2;

            }
            else if (GetMin(perimeterOfSideOne, perimeterOfSideTwo, perimeterOfSideThree) == perimeterOfSideTwo)
            {
                //p2 is smallest
                runningTotalCount += surfaceArea + perimeterOfSideTwo / 2;
            }
            else
            {
                //p3 is smallest
                runningTotalCount += surfaceArea + perimeterOfSideThree / 2;
            }
        }

        private void AddRibbon(int length, int width, int height)
        {
            int perimeterOfSideOne = CalculatePerimeter(length, width);
            int perimeterOfSideTwo = CalculatePerimeter(width, height);
            int perimeterOfSideThree = CalculatePerimeter(height, length);

            int smallestPerimeter = GetMin(perimeterOfSideOne, perimeterOfSideTwo, perimeterOfSideThree);

            int ribbonBowValue = length * width * height;

            runningRibbonTotal += smallestPerimeter + ribbonBowValue;
        }
    }
}
