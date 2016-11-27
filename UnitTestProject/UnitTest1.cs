using Cars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Car car = new Car();

            var result = car.Add(10, 10);
            Assert.AreEqual(20, result);
        }
    }
}
