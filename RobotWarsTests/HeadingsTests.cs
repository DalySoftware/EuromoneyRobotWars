using EuromoneyRobotWars;
using NUnit.Framework;

namespace RobotWarsTests;
 
[TestFixture]
public class HeadingsTests
{
    [TestCase(Headings.North, 1, Headings.East )]
    [TestCase(Headings.North, 2, Headings.South)]
    [TestCase(Headings.North, 3, Headings.West )]
    [TestCase(Headings.North, 4, Headings.North)]
    [TestCase(Headings.West,  1, Headings.North)]
    [TestCase(Headings.West,  2, Headings.East )]
    [TestCase(Headings.South, 1, Headings.West )]
    [TestCase(Headings.South, 2, Headings.North)]
    [TestCase(Headings.East,  1, Headings.South)]
    [TestCase(Headings.East,  2, Headings.West )]
    [TestCase(Headings.North,-1, Headings.West)]
    [TestCase(Headings.North,-2, Headings.South)]
    [TestCase(Headings.North,-3, Headings.East)]
    [TestCase(Headings.North,-4, Headings.North)]
    public void RotateHeadingClockwiseTests(Headings startingDirection, int turns, Headings expectedFinalDirection)
    {
        var actual = HeadingsHelper.RotateHeadingClockwise(startingDirection, turns);
        Assert.AreEqual(expectedFinalDirection, actual);
    }

    [TestCase(Headings.North, 1, Headings.West )]
    [TestCase(Headings.North, 2, Headings.South)]
    [TestCase(Headings.North, 3, Headings.East )]
    [TestCase(Headings.North, 4, Headings.North)]
    [TestCase(Headings.West,  1, Headings.South)]
    [TestCase(Headings.West,  2, Headings.East )]
    [TestCase(Headings.South, 1, Headings.East )]
    [TestCase(Headings.South, 2, Headings.North)]
    [TestCase(Headings.East,  1, Headings.North)]
    [TestCase(Headings.East,  2, Headings.West )]
    [TestCase(Headings.North,-1, Headings.East)]
    [TestCase(Headings.North,-2, Headings.South)]
    [TestCase(Headings.North,-3, Headings.West)]
    [TestCase(Headings.North,-4, Headings.North)]
    public void RotateHeadingAntiClockwiseTests(Headings startingDirection, int turns, Headings expectedFinalDirection)
    {
        var actual = HeadingsHelper.RotateHeadingAntiClockwise(startingDirection, turns);
        Assert.AreEqual(expectedFinalDirection, actual);
    }
}
