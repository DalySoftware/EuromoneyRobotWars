namespace EuromoneyRobotWars
{
    public class InvalidGridPositionException : Exception
    {
        public InvalidGridPositionException()
        {
        }

        public InvalidGridPositionException(string message)
            : base(message)
        {
        }

        public InvalidGridPositionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
