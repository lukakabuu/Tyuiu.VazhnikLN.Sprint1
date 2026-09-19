using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VazhnikLN.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Cos(3.1415926535 / x) / (3 * Math.Pow(2.71828, x + y)), 3);
        }
    }
}
