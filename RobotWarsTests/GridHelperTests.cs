using EuromoneyRobotWars;
using NUnit.Framework;

namespace RobotWarsTests;

[TestFixture]
public class GridHelperTests
{
    [Test]
    public void SetX_ShouldThrowInvalidGridPositionException_WhenValueLessThan0()
    {
        Assert.Throws<InvalidGridPositionException>(() => GridHelper.ValidateXValue(-1));
    }

    [Test]
    public void SetX_ShouldThrowInvalidGridPositionException_WhenValueGreaterThan4()
    {
        Assert.Throws<InvalidGridPositionException>(() => GridHelper.ValidateXValue(5));
    }

    [Test]
    public void SetX_ShouldNotThrow_WhenValueIs3()
    {

        Assert.DoesNotThrow(() => GridHelper.ValidateXValue(3));
    }

    [Test]
    public void SetY_ShouldThrowInvalidGridPositionEYception_WhenValueLessThan0()
    {
        Assert.Throws<InvalidGridPositionException>(() => GridHelper.ValidateYValue(-1));
    }

    [Test]
    public void SetY_ShouldThrowInvalidGridPositionEYception_WhenValueGreaterThan4()
    {
        Assert.Throws<InvalidGridPositionException>(() => GridHelper.ValidateYValue(5));
    }

    [Test]
    public void SetY_ShouldNotThrow_WhenValueIs3()
    {

        Assert.DoesNotThrow(() => GridHelper.ValidateYValue(3));
    }
}
