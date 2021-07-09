using HepsiBurada_Case_Study;
using System;
using Xunit;

namespace Case_Study_Test
{
    public class CaseStudyTest
    {

        int plateauUpperRightX = Convert.ToInt32(5);
        int plateauUpperRightY = Convert.ToInt32(5);
        Rover rover;
        [Fact]
        public void ShouldCompassNorthAndPosXY13()
        {
            Compass compass = new Compass(new North());
            rover = new Rover(1, 2, plateauUpperRightX, plateauUpperRightY, compass);

            rover.Spin(Turn.LEFT);
            rover.Move();
            rover.Spin(Turn.LEFT);
            rover.Move();
            rover.Spin(Turn.LEFT);
            rover.Move();
            rover.Spin(Turn.LEFT);
            rover.Move();
            rover.Move();

            Assert.Equal(1, rover.posX);
            Assert.Equal(3, rover.posY);
            Assert.IsType<North>(rover.compass.getDirection());
        }

        [Fact]
        public void ShouldCompassEastAndPosXY51()
        {
            Compass compass = new Compass(new East());
            rover = new Rover(3, 3, plateauUpperRightX, plateauUpperRightY, compass);

            rover.Move();
            rover.Move();
            rover.Spin(Turn.RIGHT);
            rover.Move();
            rover.Move();
            rover.Spin(Turn.RIGHT);
            rover.Move();
            rover.Spin(Turn.RIGHT);
            rover.Spin(Turn.RIGHT);
            rover.Move();
            Assert.Equal(5, rover.posX);
            Assert.Equal(1, rover.posY);
            Assert.IsType<East>(rover.compass.getDirection());
        }

        [Fact]
        public void ShouldPosXY34()
        {
            Compass compass = new Compass(new East());
            rover = new Rover(3, 3, plateauUpperRightX, plateauUpperRightY, compass);

            rover.Spin(Turn.RIGHT);
            Assert.IsType<South>(rover.compass.getDirection());
            rover.Spin(Turn.RIGHT);
            Assert.IsType<West>(rover.compass.getDirection());
            rover.Spin(Turn.RIGHT);
            Assert.IsType<North>(rover.compass.getDirection());
            rover.Spin(Turn.RIGHT);
            Assert.IsType<East>(rover.compass.getDirection());
            rover.Spin(Turn.RIGHT);
            Assert.IsType<South>(rover.compass.getDirection());
            rover.Spin(Turn.RIGHT);
            Assert.IsType<West>(rover.compass.getDirection());
            rover.Spin(Turn.RIGHT);
            Assert.IsType<North>(rover.compass.getDirection());
            rover.Move();
            Assert.Equal(3, rover.posX);
            Assert.Equal(4, rover.posY);
        }
        [Fact]
        public void ShouldFalseLastMove()
        {
            Compass compass = new Compass(new North());
            rover = new Rover(1, 2, plateauUpperRightX, plateauUpperRightY, compass);

            rover.Spin(Turn.LEFT);
            Assert.True(rover.Move());
            Assert.False(rover.Move());
        }
    }
}
