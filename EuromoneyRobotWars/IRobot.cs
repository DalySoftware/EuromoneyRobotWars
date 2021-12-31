namespace EuromoneyRobotWars;

internal interface IRobot
{
    int X { get; }
    int Y { get; }

    Headings Heading { get; }
}
