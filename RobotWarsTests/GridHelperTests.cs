using EuromoneyRobotWars;
using NUnit.Framework;

namespace RobotWarsTests;

[TestFixture]
public class GridHelperTests
{
    [Test]
    public void ValidateXValue_ShouldThrowInvalidGridPositionException_WhenValueLessThan0()
    {
        Assert.Throws<InvalidGridPositionException>(() => GridHelper.ValidateXValue(-1));
    }

    [Test]
    public void ValidateXValue_ShouldThrowInvalidGridPositionException_WhenValueGreaterThan4()
    {
        Assert.Throws<InvalidGridPositionException>(() => GridHelper.ValidateXValue(5));
    }

    [Test]
    public void ValidateXValue_ShouldNotThrow_WhenValueIs3()
    {

        Assert.DoesNotThrow(() => GridHelper.ValidateXValue(3));
    }

    [Test]
    public void ValidateYValue_ShouldThrowInvalidGridPositionEYception_WhenValueLessThan0()
    {
        Assert.Throws<InvalidGridPositionException>(() => GridHelper.ValidateYValue(-1));
    }

    [Test]
    public void ValidateYValue_ShouldThrowInvalidGridPositionEYception_WhenValueGreaterThan4()
    {
        Assert.Throws<InvalidGridPositionException>(() => GridHelper.ValidateYValue(5));
    }

    [Test]
    public void ValidateYValue_ShouldNotThrow_WhenValueIs3()
    {

        Assert.DoesNotThrow(() => GridHelper.ValidateYValue(3));
    }
}
