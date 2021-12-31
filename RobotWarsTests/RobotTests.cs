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
        public void MoveForwardPenaltyTests(int startingX, int startingY, Headings startingHeading, int expectedPenalties)

        {
            Robot robot = new(startingX, startingY, startingHeading);


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
        public void MoveForwardPositionTests(int startingX, int startingY, Headings startingHeading, int expectedX, int expectedY)
        {
            Robot robot = new(startingX, startingY, startingHeading);

            robot.MoveForward();



            Assert.AreEqual(expectedX, robot.X);
            Assert.AreEqual(expectedY, robot.Y);
        }

        [TestCase(0, 2, Headings.East, "MLMRMMMRMMRR", 4, 1, Headings.North, 0, TestName = "Test Scenario 1")]
        [TestCase(4, 4, Headings.South, "LMLLMMLMMMRMM", 0, 1, Headings.West, 1, TestName = "Test Scenario 2")]
        [TestCase(2, 2, Headings.West, "MLMLMLM RMRMRMRM", 2, 2, Headings.North, 0, TestName = "Test Scenario 3")]
        [TestCase(1, 3, Headings.North, "MMLMMLMMMMM", 0, 0, Headings.South, 3, TestName = "Test Scenario 4")]
        public void SpecifiedScenarioTests(int startingX, int startingY, Headings startingHeading, string instructions, int expectedX, int expectedY, Headings expectedHeading, int expectedPenalties)
        {
            Robot robot = new(startingX, startingY, startingHeading);


            robot.ExecuteInstructions(instructions);


            Assert.AreEqual(expectedX, robot.X);
            Assert.AreEqual(expectedY, robot.Y);
            Assert.AreEqual(expectedPenalties, robot.PenaltyCount);
        }
    }
}
