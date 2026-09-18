
using System.Threading.Tasks.Sources;
using tyuiu.cources.programming.interfaces.Sprint1;
using System;
namespace Tyuiu.VazhnikLN.Sprint1.Task2.V25.Lib
{
    public class DataService : ISprint1Task2V25
    {
        public double ConvertRadsToDegrees(int value)
        {
            return Math.Round(value * (180 / 3.14159265358979323846264338327950288419716), 3, MidpointRounding.AwayFromZero);
        }
    }
}
