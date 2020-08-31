using AdventOfCode2015.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2015.Utilities
{
    public class Elevator: IElevator
    {
        private int currentFloor;

        public Elevator()
        {
            currentFloor = 0;
        }

        public int GetCurrentFloor()
        {
            return currentFloor;
        }

        public void MoveUp()
        {
            currentFloor++;
        }

        public void MoveDown()
        {
            currentFloor--;
        }

        public void Reset()
        {
            currentFloor = 0;
        }
    }
}
