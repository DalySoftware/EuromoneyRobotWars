namespace EuromoneyRobotWars;

public class Robot : IRobot
{
    private int x;
    private int y;

    public Headings Heading { get; private set; }

    public Robot(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X
    {
        get => x;
        set
        {
            if (value < 0)
            {
                throw new InvalidGridPositionException($"X value {value} is less than 0");
            }

            if (value > 4)
            {
                throw new InvalidGridPositionException($"X value {value} is greater than 4");
            }

            x = value;
        }
    }
    public int Y
    {
        get => y;
        set
        {
            if (value < 0)
            {
                throw new InvalidGridPositionException($"Y value {value} is less than 0");
            }

            if (value > 4)
            {
                throw new InvalidGridPositionException($"Y value {value} is greater than 4");
            }

            y = value;
        }
    }

    public void RotateLeft()
    {
        Heading = HeadingsHelper.RotateHeadingAntiClockwise(Heading, 1);
    }

    public void RotateRight()
    {
        Heading = HeadingsHelper.RotateHeadingClockwise(Heading, 1);
    }

}
