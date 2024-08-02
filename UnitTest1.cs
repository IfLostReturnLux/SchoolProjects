using ConsoleApp1;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            var result = calc.Add(3, 2);
            Assert.AreEqual(5, result);
            result = calc.Subtract(3, 2);
            Assert.AreEqual(1, result);
            result = calc.Multiply(3, 2);

            //Equal
            Assert.AreEqual(6, result);
        }
    }
}