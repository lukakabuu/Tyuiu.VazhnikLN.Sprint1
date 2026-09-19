using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VazhnikLN.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            return Math.Round(number % 10) * 100 + Math.Round(number / 10 % 10) * 10 + Math.Round(number / 100) + Math.Round(number - Math.Round(number), 3);

        }
    }
}
