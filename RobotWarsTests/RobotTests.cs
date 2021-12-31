using EuromoneyRobotWars;
using NUnit.Framework;

namespace RobotWarsTests;

[TestFixture]
public class RobotTests
{
    [Test]
    public void SetX_ShouldThrowInvalidGridPositionException_WhenValueLessThan0()
    {
        Robot robot = new(0, 0);
        Assert.Throws<InvalidGridPositionException>(() => robot.X = -1);
    }

    [Test]
    public void SetX_ShouldThrowInvalidGridPositionException_WhenValueGreaterThan4()
    {
        Robot robot = new(0, 0);
        Assert.Throws<InvalidGridPositionException>(() => robot.X = 5);
    }

    [Test]
    public void SetX_ShouldSetValue_WhenValueIs3()
    {
        Robot robot = new(0, 0);
        robot.X = 3;

        Assert.AreEqual(3, robot.X);
    }

    [Test]
    public void SetY_ShouldThrowInvalidGridPositionEYception_WhenValueLessThan0()
    {
        Robot robot = new(0, 0);
        Assert.Throws<InvalidGridPositionException>(() => robot.Y = -1);
    }

    [Test]
    public void SetY_ShouldThrowInvalidGridPositionEYception_WhenValueGreaterThan4()
    {
        Robot robot = new(0, 0);
        Assert.Throws<InvalidGridPositionException>(() => robot.Y = 5);
    }

    [Test]
    public void SetY_ShouldSetValue_WhenValueIs3()
    {
        Robot robot = new(0, 0);
        robot.Y = 3;

        Assert.AreEqual(3, robot.Y);
    }
}
