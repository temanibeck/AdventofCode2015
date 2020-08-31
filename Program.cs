using AdventOfCode2015.Day1;
using AdventOfCode2015.DayTwo;
using AdventOfCode2015.Utilities;
using System;
using System.Linq;

namespace AdventOfCode2015
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var solver = new DayOneSolver(new FileReader());

            solver.SolvePartOne();

            solver.SolvePartTwo();

            var solverTwo = new DayTwoSolver(new FileReader());

            //solverTwo.SolvePartOne();

            solverTwo.SolvePartTwo();

        }
    }
}
