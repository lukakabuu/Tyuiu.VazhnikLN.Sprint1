using Tyuiu.VazhnikLN.Sprint1.Task5.V4.Lib;
namespace Tyuiu.VazhnikLN.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 10000;
            var res = ds.SecondsToHours(x);
            Assert.AreEqual(2, res);
        }
    }
}
