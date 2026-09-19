using Tyuiu.VazhnikLN.Sprint1.Task4.V13.Lib;
namespace Tyuiu.VazhnikLN.Sprint1.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.002, res);
        }
    }
}
