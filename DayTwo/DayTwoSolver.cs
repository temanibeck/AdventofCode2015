using AdventOfCode2015.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2015.DayTwo
{
    public class DayTwoSolver
    {
        private FileReader _fileReader;
        //private string _parsedInput;
        private string[] _input;

        public DayTwoSolver(FileReader fileReader)
        {
            _fileReader = fileReader;
            _input = _fileReader.ReadLine("DayTwo/input.txt").ToArray();
            //_parsedInput = input[0];
        }

        List<int> allMeasurements = new List<int>();
        List<int> newRibbonValues = new List<int>();
        public void Execute(string instruction)
        {
            string[] measurements;
            measurements = instruction.Split('x');
            //convert to int
            int[] measurementValues = Array.ConvertAll(measurements, int.Parse);

            List<int> newMeasurementValues = new List<int>();

            newMeasurementValues.Add(2 * (measurementValues[0] * measurementValues[1]));

            newMeasurementValues.Add(2 * (measurementValues[1] * measurementValues[2]));

            newMeasurementValues.Add(2 * (measurementValues[2] * measurementValues[0]));

            //Console.WriteLine($"The lwh values for Day Two are {measurementValues[0]}, {measurementValues[1]}, {measurementValues[2]}");

            newMeasurementValues.Sort();

            int surfaceArea = newMeasurementValues.Sum() + (newMeasurementValues[0] / 2);

            allMeasurements.Add(surfaceArea);

            //multiply based on instruction

            //Console.WriteLine($"The solution to Day Two Part One is {surfaceArea}");

            //2x3x4
            List<int> ribbonValues = new List<int>(measurementValues);
            //measurementValues.ToList();
            ribbonValues.Sort();

            Console.WriteLine($"Measurement Values: {ribbonValues[0]}, {ribbonValues[1]}, {ribbonValues[2]}");

            //2+2+3+3
            //ribbonValues.Add((2 * measurementValues[0]) + (2 * measurementValues[1]));
            int ribbonWrapValue = (2 * ribbonValues[0]) + (2 * ribbonValues[1]);
            //2x3x4
            int ribbonBowValue = ribbonValues[0] * ribbonValues[1] * ribbonValues[2];

            int ribbonNeeded = ribbonWrapValue + ribbonBowValue;

            newRibbonValues.Add(ribbonNeeded);

            //Console.WriteLine($"The amount of ribbon needed for Day Two Part Two is {ribbonNeeded}");
        }

        public void SolvePartOne()
        {
            int finalSum = 0;
            foreach(string instruction in _input)
            {
                Execute(instruction);
                finalSum = allMeasurements.Sum();
            }

            Console.WriteLine($"The solution to Day Two Part One is {finalSum}");
        }

        public void SolvePartTwo()
        {
            int finalSum = 0;
            foreach (string instruction in _input)
            {
                Execute(instruction);
                finalSum = newRibbonValues.Sum();
            }

            Console.WriteLine($"The solution to Day Two Part Two is {finalSum}");
        }

        //private IElevator _elevator;

        //public DayOneSolver(FileReader fileReader)
        //{
        //    _elevator = new Elevator();
        //}

        //public void SolvePartOne()
        //{
        //    _elevator.Reset();

        //    foreach (var instruction in _parsedInput)
        //    {
        //        Execute(instruction);
        //    }

        //    Console.WriteLine($"The solution to part one is {_elevator.GetCurrentFloor()}");
        //}

        ////hw: fix test for part one and part two of Day One Solver
        //public void SolvePartTwo()
        //{
        //    var count = 0;
        //    _elevator.Reset();

        //    foreach (var instruction in _parsedInput)
        //    {
        //        Execute(instruction);

        //        count++;

        //        if (_elevator.GetCurrentFloor() == -1)
        //        {
        //            break;
        //        }
        //    }

        //    Console.WriteLine($"The solution to part two is {count}");
        //}
    }
}
