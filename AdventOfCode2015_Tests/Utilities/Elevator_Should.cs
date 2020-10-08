using AdventOfCode2015.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AdventOfCode2015_Tests.Utilities
{
    public class Elevator_Should
    {
        [Fact]
        public void StartAtFloorZero()
        {
            //arrange
            var expectedFloor = 0;

            //act
            var elevator = new Elevator();
            var actualFloor = elevator.GetCurrentFloor();

            //assert
            Assert.Equal(expectedFloor, actualFloor);
        }

        [Fact]

        public void MoveUpOneFloor()
        {
            //arrange
            var expectedFloor = 1;

            //act
            var elevator = new Elevator();
            elevator.MoveUp();
            var actualFloor = elevator.GetCurrentFloor();

            //assert
            Assert.Equal(expectedFloor, actualFloor);
        }

        [Fact]
        public void MoveDownOneFloor()
        {
            //arrange
            var expectedFloor = -1;

            //act
            var elevator = new Elevator();
            elevator.MoveDown();
            var actualFloor = elevator.GetCurrentFloor();

            //assert
            Assert.Equal(expectedFloor, actualFloor);
        }
    }
}
