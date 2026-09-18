using Tyuiu.VazhnikLN.Sprint1.Task1.V16.Lib;
namespace Tyuiu.VazhnikLN.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 5.0;
            double a = 9.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(145.0, res);


        }
    }
}
