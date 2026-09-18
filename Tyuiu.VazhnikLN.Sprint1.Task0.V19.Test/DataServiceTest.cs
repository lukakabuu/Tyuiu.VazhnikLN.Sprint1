using Tyuiu.VazhnikLN.Sprint1.Task0.V19.Lib;
namespace Tyuiu.VazhnikLN.Sprint1.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiveTest
    {
        [TestMethod]
        public void ValidExpression()

        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(24, res);
        }
    }
}
