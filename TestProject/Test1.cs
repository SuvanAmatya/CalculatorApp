using CalculatorApp;

namespace TestProject
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Add add = new Add();
            int a = 5;
            int b = 6;
            int result = add.AddNumbers(a, b);
            Assert.AreEqual(11, result);
        }
    }
}
