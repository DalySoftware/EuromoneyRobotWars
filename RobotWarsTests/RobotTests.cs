using EuromoneyRobotWars;
using NUnit.Framework;

namespace RobotWarsTests
{
    [TestFixture]
    public class RobotTests
    {
        [TestCase(0, 0, Headings.West, 1)]
        [TestCase(0, 0, Headings.East, 0)]
        [TestCase(0, 4, Headings.North, 1)]
        [TestCase(0, 4, Headings.South, 0)]
        [TestCase(4, 4, Headings.North, 1)]
        [TestCase(4, 4, Headings.South, 0)]
        [TestCase(4, 0, Headings.East, 1)]
        [TestCase(4, 0, Headings.West, 0)]
        public void MoveForwardPenaltyTests(int startingX, int startingY, Headings startingDirection, int expectedPenalties)

        {
            Robot robot = new(startingX, startingY, startingDirection);


            robot.MoveForward();


            Assert.AreEqual(robot.PenaltyCount, expectedPenalties);
        }

        [TestCase(0, 0, Headings.West, 0, 0)]
        [TestCase(0, 0, Headings.East, 1, 0)]
        [TestCase(0, 4, Headings.North, 0, 4)]
        [TestCase(0, 4, Headings.South, 0, 3)]
        [TestCase(4, 4, Headings.North, 4, 4)]
        [TestCase(4, 4, Headings.South, 4, 3)]
        [TestCase(4, 0, Headings.East, 4, 0)]
        [TestCase(4, 0, Headings.West, 3, 0)]
        public void MoveForwardPositionTests(int startingX, int startingY, Headings startingDirection, int expectedX, int expectedY)
        {
            Robot robot = new(startingX, startingY, startingDirection);


            robot.MoveForward();


            Assert.AreEqual(expectedX, robot.X);
            Assert.AreEqual(expectedY, robot.Y);
        }
    }
}
