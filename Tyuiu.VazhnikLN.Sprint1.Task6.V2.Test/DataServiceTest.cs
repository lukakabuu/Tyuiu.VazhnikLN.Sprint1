using Tyuiu.VazhnikLN.Sprint1.Task6.V2.Lib;
namespace Tyuiu.VazhnikLN.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            string x = "Hello, world";
            var res = ds.CheckHello(x);
            Assert.AreEqual(true, res);
        }
    }
}
