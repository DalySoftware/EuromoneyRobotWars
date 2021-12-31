using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuromoneyRobotWars
{
    public static class GridHelper
    {
        private static void ValidateValue(int newValue, string direction)
        {
            if (newValue < 0)
            {
                throw new InvalidGridPositionException($"{direction} newValue {newValue} is less than 0");
            }

            if (newValue > 4)
            {
                throw new InvalidGridPositionException($"{direction} newValue {newValue} is greater than 4");
            }
        }

        public static void ValidateXValue(int newValue)
        {
            ValidateValue(newValue, "X");
        }

        public static void ValidateYValue(int newValue)
        {
            ValidateValue(newValue, "Y");
        }
    }
}
