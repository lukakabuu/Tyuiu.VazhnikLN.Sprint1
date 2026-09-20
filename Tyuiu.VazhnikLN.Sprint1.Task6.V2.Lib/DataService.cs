using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VazhnikLN.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            string s2 = "Hello";
            return value.Contains(s2);
        }
    }
}
