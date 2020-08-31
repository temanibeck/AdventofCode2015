using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2015.Interfaces
{
    interface IElevator
    {
        int GetCurrentFloor();

        void MoveUp();

        void MoveDown();

        void Reset();

    }
}
