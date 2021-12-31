namespace EuromoneyRobotWars;

public class Robot
{
    private int x;
    private int y;

    public Headings Heading { get; private set; }
    public int PenaltyCount { get; private set; }

    public Robot(int x = 0, int y = 0, Headings heading = Headings.North)
    {
        X = x;
        Y = y;
        Heading = heading;
    }

    public int X
    {
        get => x;
        private set
        {
            GridHelper.ValidateXValue(value);

            x = value;
        }
    }
    public int Y
    {
        get => y;
        private set
        {
            GridHelper.ValidateYValue(value);

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

    public void MoveForward()
    {
        try
        {
            switch (Heading)
            {
                case Headings.North:
                    Y += 1;
                    break;
                case Headings.South:
                    Y -= 1;
                    break;
                case Headings.East:
                    X += 1;
                    break;
                case Headings.West:
                    X -= 1;
                    break;
            }
        }
        catch (InvalidGridPositionException)
        {
            PenaltyCount++;
        }
    }
}
