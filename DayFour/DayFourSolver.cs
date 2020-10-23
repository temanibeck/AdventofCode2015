using AdventOfCode2015.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2015.DayFour
{
    public class DayFourSolver
    {
        private FileReader _fileReader;
        private string[] _input;
        private string password = "abc123";

        public DayFourSolver(FileReader fileReader)
        {
            _fileReader = fileReader;
            _input = _fileReader.ReadLine("DayFour/Input.txt").ToArray();
        }

        public void SolvePartOne()
        {
            //for (int.max) or while loop with counter
            //break
            //password, md5 hash, five zeros, !five zeros: append int counting up, hash
            Console.WriteLine($"The solution to Day Four Part One is {coordinateSet.Count()}");
        }

        public void SolvePartTwo()
        {
            
            Console.WriteLine($"The solution to Day Four Part One is {coordinateSet.Count()}");
        }

        public void Execute()
        {

        }
    }
}
