namespace EuromoneyRobotWars;

public enum Headings { North = 0, East = 1, South = 2, West = 3 }

public static class HeadingsHelper
{
    private static int Modulo(int a, int b)
    {
        int c = a % b;
        if ((c < 0 && b > 0) || (c > 0 && b < 0))
        {
            c += b;
        }
        return c;
    }

    public static Headings RotateHeadingClockwise(Headings startingDirection, int turns)
    {
        var startingAsInt = (int)startingDirection;

        var newDirection = Modulo(startingAsInt + turns, 4);

        return (Headings)newDirection;
    }

    public static Headings RotateHeadingAntiClockwise(Headings startingDirection, int turns)
    {
        return RotateHeadingClockwise(startingDirection, -turns);
    }
}
