using Tyuiu.VazhnikLN.Sprint1.Task7.V23.Lib;
namespace Tyuiu.VazhnikLN.Sprint1.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.725, res);

        }
    }
}
