using Tyuiu.VazhnikLN.Sprint1.Task3.V14.Lib;
namespace Tyuiu.VazhnikLN.Sprint1.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            double x = 123.2137124124;
            var res = ds.ReverseNumber(x);
            Assert.AreEqual(321.214, res);
            
        }
    }
}
